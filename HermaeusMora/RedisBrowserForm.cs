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
using BrightIdeasSoftware;
using Svekla.ServiceStack;
using Svekla.Utilities;

namespace Svekla
{
    public partial class RedisBrowserForm : Form
    {
        // Constants
        const String CACHE_DIR = "cache\\";

        // Parent Form and Related
        MainForm parent;

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
        private SveklaRedisClient redisClient;
        private List<RedisClientInfo> clientList;
        private Boolean clientCommandSupported = false;

        // Async Loading
        private BackgroundWorker asyncLoader;
        private Boolean loaderCancelling;

        // Local Key Index
        List<RedisTopLevelEntity> keys = null;


        /// <summary>
        /// Constructor
        /// </summary>
        public RedisBrowserForm(MainForm parent)
        {
            InitializeComponent();

            // Initialize Variables
            clientList = new List<RedisClientInfo>();

            // Mdi
            this.MdiParent = parent;
            this.parent = parent;

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
            if (Environment.OSVersion.Platform == PlatformID.Win32NT &&
                (Environment.OSVersion.Version >= new Version(6, 1)))
            {
                olvKeys.SetNativeBackgroundWatermark(Properties.Resources.KeyListBG);
                olvKeys.GridLines = true;
            }
            olvcKey.ImageGetter = (Object row) =>
                {
                    RedisTopLevelEntity en = (RedisTopLevelEntity)row;
                    return (int)en.Type;
                };
            olvcTTL.AspectToStringConverter = delegate(Object o)
            {
                DateTime en = (DateTime)o;
                if (en == null || en < DateTime.Now)
                    return "N/A";
                else
                    return en.ToString();
            };

            // CLient List
            AspectToStringConverterDelegate clientValConv = new AspectToStringConverterDelegate((Object o) =>
                {
                    Int32 i = (Int32)o;
                    if (i >= 0) return i.ToString();
                    else return "N/A";
                });
            olvcAge.AspectToStringConverter = clientValConv;
            olvcDb.AspectToStringConverter = clientValConv;
            olvcFileHandle.AspectToStringConverter = clientValConv;
            olvcIdle.AspectToStringConverter = clientValConv;
            olvcMulti.AspectToStringConverter = clientValConv;
            olvcObl.AspectToStringConverter = clientValConv;
            olvcOll.AspectToStringConverter = clientValConv;
            olvcOmem.AspectToStringConverter = clientValConv;
            olvcPSub.AspectToStringConverter = clientValConv;
            olvcQbuf.AspectToStringConverter = clientValConv;
            olvcQbufF.AspectToStringConverter = clientValConv;
            olvcSub.AspectToStringConverter = clientValConv;

            // event handlers
            this.FormClosing += (Object o, FormClosingEventArgs e) => { if (timer.Enabled) timer.Stop(); if (redisClient != null) redisClient.Dispose(); };

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
            if (reply.Status != IPStatus.Success) OnConnectionError();

            try
            {
                Dictionary<String, String> srvInfo = redisClient.Info;
                Int32 srvDbSize = redisClient.DbSize;
                DateTime lSave = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                lSave.AddSeconds(Int32.Parse(srvInfo.GetOrDefault("last_save_time", "0")));

                RedisClientInfo[] clients = null;
                if (clientCommandSupported) clients = redisClient.GetClientList();
               
                this.BeginInvoke(new Action(() =>
                {
                    this.Text = String.Format(locale.GetString("RBF_TitleConnected"), serverHost, serverPort, reply.RoundtripTime);

                    lblSmVersion.Text = String.Format("Redis {0} ({1}bit)", srvInfo.GetOrDefault("redis_version", "??"), srvInfo.GetOrDefault("arch_bits", "??"));
                    lblSmDbSize.Text = String.Format("{0} Keys", srvDbSize);
                    lblSmMem.Text = String.Format("{0}/{1}", srvInfo.GetOrDefault("used_memory_human", "??"), srvInfo.GetOrDefault("used_memory_peak_human", "??"));
                    lblSmLastSave.Text = lSave.ToString();
                    lblSmClients.Text = srvInfo.GetOrDefault("connected_clients", "??");

                    if (clientCommandSupported) SyncClientList(clients);
                }));
            }
            catch
            {
                OnConnectionError();
            }

        }

        protected override void WndProc(ref Message m)
        {
            const int WM_EXITSIZEMOVE = 0x232;

            switch (m.Msg)
            {
                case WM_EXITSIZEMOVE:
                    base.WndProc(ref m);
                    OnNeedRedrawParent();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

    
        #region MDI Parent Interfacing

        // Events
        private EventHandler _onConnected;
        private EventHandler _onNeedRedrawParent;

        public event EventHandler Connected
        { add { _onConnected += value; } remove { _onConnected -= value; } }
        public event EventHandler NeedRedrawParent
        { add { _onNeedRedrawParent += value; } remove { _onNeedRedrawParent -= value; } }

        private void OnConnected()
        {
            if (_onConnected != null)
                _onConnected(this, new EventArgs());
        }
        private void OnNeedRedrawParent()
        {
            if (_onNeedRedrawParent != null)
                _onNeedRedrawParent(this, new EventArgs());
        }

        public Boolean IsConnected
        { get { return redisClient != null; } }

        public String ServerAddress
        { get { return serverHost != null ? String.Format("{0}:{1}", serverHost, serverPort) : MainForm.NOT_CONNECTED_SRV; } }



        #endregion

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

            // check if this connection is duplicate
            if (parent.TryActivateDuplicate(this))
                return;

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
                if (reply != null && reply.Status == IPStatus.TimedOut)
                {
                    // { overallSuccess, statusMessage }
                    arg.Result = new Object[] { false, "RBF_ErrHostTimeout", "" };
                    return;
                }
                else if (reply == null || reply.Status != IPStatus.Success)
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

                poke.Dispose();

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

            // Initialize UI
            lblSmServerName.Text = String.Format("{0}:{1}", host, port);

            // create redis client
            if (pwd.Length > 0)
                redisClient = new SveklaRedisClient(host, port, pwd);
            else
                redisClient = new SveklaRedisClient(host, port);


            // update ping
            UpdatePingDelay();

            // connected
            OnConnected();

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
                            entity.Type = RedisTopLevelEntity.ParseType(client.GetEntryType(key));
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

                        // check if client command is supported
                        if (redisClient.ServerVersion < Version.Parse("2.4.0"))
                        {
                            OnClientListError(locale.GetString("RBF_ClientNotSupported"));
                        }
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

        private void OnClientListError(String err)
        {
            clientCommandSupported = false;

            TextOverlay to = new TextOverlay();
            to.Text = String.Format("{0}\n{1}", locale.GetString("RBF_ClientFetchFail"), err);
            to.TextColor = Color.DarkRed;
            to.Alignment = ContentAlignment.MiddleCenter;

            olvClients.OverlayText = to;
            olvClients.ContextMenu = null;
            olvClients.ShowOverlays();
        }

        private void SyncClientList(RedisClientInfo[] clients)
        {
            if (clients.Length < clientList.Count)
                clientList.RemoveRange(clients.Length, clientList.Count - clients.Length);

            for (int i = 0; i < clients.Length; i++)
            {
                if (i >= clientList.Count)
                    clientList.Add(new RedisClientInfo());
                clients[i].CopyTo(clientList[i]);
            }

            olvClients.Objects = clientList;

            olvClients.RefreshObjects(clients);
        }

        private void OnConnectionError()
        {
            timer.Enabled = false;
            if (MessageBox.Show(locale.GetString("RBF_ConnectionInterrupted"), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Cancel)
                this.Close();
            else
            {
                UpdatePingDelay();
                timer.Enabled = true;
            }
        }

        #endregion

        private void cms_c_kill_Click(object sender, EventArgs e)
        {
            if (olvClients.SelectedObjects.Count == 0) return;
            RedisClientInfo rci = (RedisClientInfo)olvClients.SelectedObject;

            redisClient.KillClientConnection(rci);

        }

        #region Utility Methods



        #endregion
    }
}
