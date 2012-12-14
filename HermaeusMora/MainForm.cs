using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using Svekla.UI.Components;

namespace Svekla
{
    public partial class MainForm : Form
    {
        public const string NOT_CONNECTED_SRV = "none";

        public MainForm()
        {
            InitializeComponent();
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
           
            // Event handlers
            this.MdiChildActivate += OnChildActivated;
        }

        #region MDI Children Management/Interfacing

        Dictionary<String, RedisBrowserForm> mdiChildren = new Dictionary<string, RedisBrowserForm>();

        public MdiClient GetMdiClient()
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    return (MdiClient)c;
            }
            return null;
        }

        public void AddMdiChild()
        {
            if (mdiChildren.ContainsKey(NOT_CONNECTED_SRV))
                mdiChildren[NOT_CONNECTED_SRV].Activate();
            else
            {
                RedisBrowserForm rbf = new RedisBrowserForm(this);
                mdiChildren.Add(NOT_CONNECTED_SRV, rbf);

                rbf.Connected += OnChildConnected;
                rbf.FormClosed += OnChildClosed;

                rbf.Show();
            }
        }

        /// <summary>
        /// If a form with connection to the same address already exisis,
        /// that form will be focused and the method will return true;
        /// otherwise returns false
        /// </summary>
        /// <param name="rbf"></param>
        /// <returns></returns>
        public Boolean TryActivateDuplicate(RedisBrowserForm rbf)
        {
            if (mdiChildren.ContainsKey(rbf.ServerAddress))
            {
                mdiChildren[rbf.ServerAddress].Activate();
                return true;
            }
            return false;
        }

        public void OnChildConnected(Object o, EventArgs e)
        {
            if (o is RedisBrowserForm)
            {
                RedisBrowserForm rbf = (RedisBrowserForm)o;

                mdiChildren.Remove(NOT_CONNECTED_SRV);
                mdiChildren.Add(rbf.ServerAddress, rbf);

                OnChildActivated(rbf, null);
            }
        }

        public void OnChildClosed(Object o, EventArgs e)
        {
            if (o is RedisBrowserForm)
            {
                RedisBrowserForm rbf = (RedisBrowserForm)o;
                mdiChildren.Remove(rbf.ServerAddress);
                // Hide server options
                mms_ssrv_bgsave.Visible = mms_ssrv_dropall.Visible = mms_ssrv_dropdb.Visible =
                   mms_ssrv_save.Visible = mms_ssrv_shutdown.Visible = mms_srv_sep1.Visible = false;
            }
        }

        public void OnChildActivated(Object o, EventArgs e)
        {
            Form mdic = this.ActiveMdiChild;
            if (mdic is RedisBrowserForm)
            {   // Redis browser form
                RedisBrowserForm rbf = (RedisBrowserForm)mdic;

                // Show server options
                mms_ssrv_bgsave.Visible = mms_ssrv_dropall.Visible = mms_ssrv_dropdb.Visible =
                      mms_ssrv_save.Visible = mms_ssrv_shutdown.Visible = mms_srv_sep1.Visible = rbf.IsConnected;
            }
            else
            {

                // Hide server options
                mms_ssrv_bgsave.Visible = mms_ssrv_dropall.Visible = mms_ssrv_dropdb.Visible =
                   mms_ssrv_save.Visible = mms_ssrv_shutdown.Visible = mms_srv_sep1.Visible = false;

            }
        }

        #endregion


        private void connectToNewServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMdiChild();
            
        }

        private void aboutSveklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SveklaAboutForm saf = new SveklaAboutForm();
            //saf.MdiParent = this;
            saf.ShowDialog();
        }

    }
}
