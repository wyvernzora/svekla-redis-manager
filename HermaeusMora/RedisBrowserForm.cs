using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Svekla.UI.Nightingale;
using Svekla.Persistence;
using ServiceStack.Redis;
using System.Resources;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using Svekla.Utilities;
using BrightIdeasSoftware;

namespace Svekla
{
    public partial class RedisBrowserForm : Form
    {
        // Constants
        const String CACHE_DIR = "cache\\";

        // Localization
        ResourceManager locale = new ResourceManager("Svekla.Resources.Locale", typeof(RedisBrowserForm).Assembly);

        // Nightingale State
        private WizardStateManager stateManager;

        // Form Update Timer
        private Timer timer;

        // Connection Related Variables
        private String serverHost;
        private Int32 serverPort;
        private Ping serverPing;

        // Redis Connection
        private IRedisClient redisClient;

        // Async Loading
        private BackgroundWorker asyncLoader;
        private Boolean loaderCancelling;

        // Local Key Index
        List<RedisTopLevelEntity> keys = null;


        /// <summary>
        /// Constructor
        /// </summary>
        public RedisBrowserForm()
        {
            InitializeComponent();

            // Add global settings handler
            GlobalSettings.Instance.SettingsChanged +=
                (Object o, GlobalSettings.SettingsChangedEventArgs e) => HandleSettingsChanges(e);

            // Initialize Form Updating
            serverPing = new Ping();
            timer = new Timer();
            timer.Interval = GlobalSettings.Instance.PingInterval;
            timer.Tick += (Object o, EventArgs e) => UpdatePingDelay();

            // Initialize States
            stateManager = new WizardStateManager();
            stateManager.AddState(wsConnect);
            stateManager.AddState(wsConnected);
            stateManager.AddState(wsLoading);
            stateManager.SetCurrentState("wsConnect");

            // Keys List
            olvcKey.ImageGetter = (Object row) =>
                {
                    RedisTopLevelEntity en = (RedisTopLevelEntity)row;
                    return (int)en.Type;
                };

            // event handlers
            this.FormClosing += (Object o, FormClosingEventArgs e) => { if (timer.Enabled) timer.Stop(); };

            wsLoading.OnActivated += (Object s, EventArgs e) => { loadingIndicator1.Enabled = true; };
            wsLoading.OnDeactivated += (Object s, EventArgs e) => { loadingIndicator1.Enabled = false; };
        }

        /// <summary>
        /// Handles config change notifications from GlobalSettings class.
        /// </summary>
        /// <param name="e"></param>
        public void HandleSettingsChanges(GlobalSettings.SettingsChangedEventArgs e)
        {
            if (e.SettingName == "PingInterval")
                timer.Interval = (int)e.NewValue;
        }

        /// <summary>
        /// Sets a new control error
        /// </summary>
        /// <param name="c">Target control</param>
        /// <param name="err">Error message</param>
        public void SetControlError(Control c, String format, params Object[] args)
        {
            errors.SetError(c, String.Format(format, args));
        }

        /// <summary>
        /// Pings the server and updates delay
        /// </summary>
        public void UpdatePingDelay()
        {
            PingReply reply = serverPing.Send(serverHost, GlobalSettings.Instance.PingTimeout);
            this.BeginInvoke(new Action(() =>
            {
                this.Text = String.Format("{0}:{1} - {2}ms", serverHost, serverPort, reply.RoundtripTime);
            }));
        }

        #region wsConnect Events

        BackgroundWorker bw = null;

        private void btnInitConnect_Click(object sender, EventArgs e)
        {

            // clear all previous errors
            errors.Clear();

            // validate input
            Boolean validated = true;

            // check if address is empty
            if (String.IsNullOrWhiteSpace(cmbServerAddress.Text))
            {
                SetControlError(cmbServerAddress, locale.GetString("RBF_AddressEmpty"));
                validated = false;
            }

            // split host/port
            String host;
            Int32 port = 6379;

            String[] sAddr = cmbServerAddress.Text.Split(':');
            if (sAddr.Length > 2)
            {
                SetControlError(cmbServerAddress, locale.GetString("RBF_AddressInvalid"));
                validated = false;
            }
            host = sAddr[0];
            if (sAddr.Length == 2 && !Int32.TryParse(sAddr[1], out port))
            {
                SetControlError(cmbServerAddress, locale.GetString("RBF_AddressInvalid"));
                validated = false;
            }

            // abort if something is wrong
            if (!validated) return;

            //
            serverHost = host;
            serverPort = port;


            // prepare UI for connection
            cmbServerAddress.Enabled = false;
            txtServerPassword.Enabled = false;
            btnInitConnect.Enabled = false;
            lblConnectionError.Visible = false;
            btnInitConnect.Text = locale.GetString("RBF_Connecting");

            // construct connection worker
            bw = new BackgroundWorker();
            bw.DoWork += (Object o, DoWorkEventArgs arg) =>
            {
                // get args
                Object[] args = (Object[])arg.Argument;
                String bw_host = (String)args[0];
                Int32 bw_port = (Int32)args[1];
                String bw_pwd = (String)args[2];

                // handle canceling
                if (arg.Cancel)
                {
                    arg.Result = new Object[] { false, "RBF_ErrUserCancel", "" };
                    return;
                }

                // poke the server
                RedisPoke poke = new RedisPoke(bw_host, bw_port);

                // try common ping
                PingReply reply = poke.PingMachine();
                if (reply.Status == IPStatus.TimedOut)
                {
                    // { overallSuccess, statusMessage }
                    arg.Result = new Object[] { false, "RBF_ErrHostTimeout", "" };
                    return;
                }
                else if (reply.Status != IPStatus.Success)
                {
                    // { overallSuccess, statusMessage }
                    arg.Result = new Object[] { false, "RBF_ErrHostError", "" };
                    return;
                }

                // handle canceling
                if (arg.Cancel)
                {
                    arg.Result = new Object[] { false, "RBF_ErrUserCancel", "" };
                    return;
                }

                // ping redis server (soft)
                RedisPoke.Result pingResult = poke.Connect();
                if (pingResult != RedisPoke.Result.Success)
                {
                    // { overallSuccess, statusMessage }
                    arg.Result = new Object[] { false, "RBF_ErrRedisTimeout", "" };
                    return;
                }

                // handle canceling
                if (arg.Cancel)
                {
                    arg.Result = new Object[] { false, "RBF_ErrUserCancel", "" };
                    return;
                }
                
                // try auth
                if (bw_pwd.Length > 0)
                {
                    RedisPoke.Result authResult = poke.Authenticate(bw_pwd);
                    if (authResult != RedisPoke.Result.Success)
                    {
                        // { overallSuccess, statusMessage }
                        arg.Result = new Object[] { false, "RBF_AccessDenied", "" };
                        return;
                    }
                }

                arg.Result = new Object[] { true, "", "" };
            };
            bw.RunWorkerCompleted += (Object s, RunWorkerCompletedEventArgs args) =>
            {
                Object[] result = (Object[])args.Result;
                Boolean success = (Boolean)result[0];
                String message = (String)result[1];
                String additional = (String)result[2];

                if (success)
                {
                    ConnectionSuccess(host, port, txtServerPassword.Text);
                }
                else
                {
                    lblConnectionError.Text = String.Format(locale.GetString("RBF_Error"), locale.GetString(message));
                    lblConnectionError.Visible = true;
                }


                cmbServerAddress.Enabled = true;
                txtServerPassword.Enabled = true;
                txtServerPassword.Clear();
                btnInitConnect.Enabled = true;
                btnInitConnect.Text = locale.GetString("RBF_Connect");
            };
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerAsync(new Object[] { host, port, txtServerPassword.Text });
        }

        private void ConnectionSuccess(String host, Int32 port, String pwd)
        {
            // start update
            timer.Start();

            // create redis client
            if (pwd.Length > 0)
                redisClient = new RedisClient(host, port, pwd);
            else
                redisClient = new RedisClient(host, port);

            // update ping
            UpdatePingDelay();

            // pull data
            PullData();
        }

        #endregion

        #region Data Pulling/Loading events

        public void PullData()
        {
            // navigate to the loading state
            stateManager.SetCurrentState("wsLoading");

            // construct worker
            asyncLoader = new BackgroundWorker();
            asyncLoader.WorkerReportsProgress = true;
            asyncLoader.WorkerSupportsCancellation = true;
            asyncLoader.DoWork += (Object o, DoWorkEventArgs e) =>
                {
                    asyncLoader.ReportProgress(0, new Object[] { "RBF_ProgressDwnKeys", 0, 0} );

                    // pass redis client to the worker thread
                    RedisClient client = (RedisClient)e.Argument;

                    // download all keys (may take a while)
                    List<String> rawKeys = client.GetAllKeys();

                    // get cache
                    String cacheFile = BuildCacheFilename(serverHost, serverPort);
                    RedisDatabaseCache cache = new RedisDatabaseCache();
                    cache.LoadFile(cacheFile);

                    // handle cancellation
                    if (loaderCancelling)
                    {
                        // { overallSuccess, result, message }
                        e.Result = new Object[] { false, null, "RBF_ErrUserCancel" };
                        return;
                    }

                    // start getting info
                    List<RedisTopLevelEntity> entities = new List<RedisTopLevelEntity>();
                    for (int i = 0; i < rawKeys.Count; i++)
                    {
                        String key = rawKeys[i];

                        // handle cancellation
                        if (loaderCancelling)
                        {
                            // { overallSuccess, result, message }
                            e.Result = new Object[] { false, null, "RBF_ErrUserCancel" };
                            return;
                        }

                        RedisTopLevelEntity entity = new RedisTopLevelEntity();
                        entity.Key = key;

                        if (cache.IsCached(key))
                        {
                            RedisDatabaseCache.CachedEntry ce = cache.GetCachedInfo(key);
                            entity.Type = ce.Type;
                            entity.ExpiresAt = ce.TTL;
                        }
                        else
                        {
                            // get key data
                            entity.Type = RedisTopLevelEntity.ParseType(client.Type(key));
                            entity.ExpiresAt = DateTime.Now + client.GetTimeToLive(key);
                         
                            // update cache
                            cache.UpdateCache(entity);

                        }

                        entities.Add(entity);

                        asyncLoader.ReportProgress(0, new Object[] { "RBF_ProgressGetInfo", i, rawKeys.Count });
                    }

                    // save cache
                    cache.WriteFile(cacheFile);

                    // pass results back
                    e.Result = new Object[] { true, entities, null };
                };
            asyncLoader.ProgressChanged += (Object o, ProgressChangedEventArgs e) =>
                {
                    Object[] args = (Object[])e.UserState;
                    String message = (String)args[0];
                    Int32 current = (Int32)args[1];
                    Int32 total = (Int32)args[2];

                    message = String.Format(locale.GetString(message), current, total);
                    lblLoadingProgressDetails.Text = message;

                    if (total != 0)
                    {
                        Int32 percentage = (int)((double)current / (double)total * 100);
                        if (percentage >= 25 && percentage < 50)
                            lblLoadingStatusTitle.Text = locale.GetString("RBF_LP25");
                        else if (percentage >= 50 && percentage < 75)
                            lblLoadingStatusTitle.Text = locale.GetString("RBF_LP50");
                        else if (percentage >= 75 && percentage < 90)
                            lblLoadingStatusTitle.Text = locale.GetString("RBF_LP75");
                        else if (percentage >= 90)
                            lblLoadingStatusTitle.Text = locale.GetString("RBF_LP90");
                        pbLoadingProgress.Value = percentage;
                    }
                };
            asyncLoader.RunWorkerCompleted += (Object o, RunWorkerCompletedEventArgs e) =>
                {
                    Object[] args = (Object[])e.Result;
                    Boolean success = (Boolean)args[0];
                    List<RedisTopLevelEntity> entities = (List<RedisTopLevelEntity>)args[1];
                    String message = (String)args[2];

                    if (success)
                    {
                        keys = entities;

                        // todo: update listview stuff

                        stateManager.SetCurrentState("wsConnected");

                        //olvKeys.SetObjects(keys);
                        olvKeys.VirtualListDataSource = new RedisKeysDataSource(keys);
                    }
                    else
                    {
                        MessageBox.Show(locale.GetString(message));

                        this.Close();
                    }
                };
            asyncLoader.RunWorkerAsync(redisClient);
        }

        private static String BuildCacheFilename(String addr, Int32 port)
        {
            return CACHE_DIR + RedisDatabaseCache.GetByteString(RedisDatabaseCache.GetMd5(String.Format("{0}:{1}", addr, port))) + ".mora";
        }

        private void btnLoadingAbort_Click(object sender, EventArgs e)
        {
            if (bw != null)
            {
                bw.CancelAsync();
                bw.Dispose();
                loaderCancelling = true;
            }
        }

        #endregion

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olvKeys.View = View.LargeIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olvKeys.View = View.Tile;

        }

    }
}
