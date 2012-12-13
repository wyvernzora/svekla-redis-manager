namespace Svekla
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mms_program = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_srv_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_srv_sep0 = new System.Windows.Forms.ToolStripSeparator();
            this.mms_ssrv_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_ssrv_bgsave = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_ssrv_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_ssrv_dropdb = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_ssrv_dropall = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_srv_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mms_srv_exitapp = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_view = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_v_large = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_v_small = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_v_list = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_v_details = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_data = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_d_string = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_d_list = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_d_set = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_d_zset = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_d_hash = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_v_sep0 = new System.Windows.Forms.ToolStripSeparator();
            this.mms_d_del = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSveklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiController = new Svekla.UI.Components.MdiClientController();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_program,
            this.mms_view,
            this.mms_data,
            this.mms_help});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // mms_program
            // 
            this.mms_program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_srv_connect,
            this.mms_srv_sep0,
            this.mms_ssrv_save,
            this.mms_ssrv_bgsave,
            this.mms_ssrv_shutdown,
            this.mms_ssrv_dropdb,
            this.mms_ssrv_dropall,
            this.mms_srv_sep1,
            this.mms_srv_exitapp});
            this.mms_program.Name = "mms_program";
            resources.ApplyResources(this.mms_program, "mms_program");
            // 
            // mms_srv_connect
            // 
            this.mms_srv_connect.Name = "mms_srv_connect";
            resources.ApplyResources(this.mms_srv_connect, "mms_srv_connect");
            this.mms_srv_connect.Click += new System.EventHandler(this.connectToNewServerToolStripMenuItem_Click);
            // 
            // mms_srv_sep0
            // 
            this.mms_srv_sep0.Name = "mms_srv_sep0";
            resources.ApplyResources(this.mms_srv_sep0, "mms_srv_sep0");
            // 
            // mms_ssrv_save
            // 
            this.mms_ssrv_save.Image = global::Svekla.Properties.Resources.Save16;
            this.mms_ssrv_save.Name = "mms_ssrv_save";
            resources.ApplyResources(this.mms_ssrv_save, "mms_ssrv_save");
            // 
            // mms_ssrv_bgsave
            // 
            this.mms_ssrv_bgsave.Image = global::Svekla.Properties.Resources.Save16;
            this.mms_ssrv_bgsave.Name = "mms_ssrv_bgsave";
            resources.ApplyResources(this.mms_ssrv_bgsave, "mms_ssrv_bgsave");
            // 
            // mms_ssrv_shutdown
            // 
            this.mms_ssrv_shutdown.Image = global::Svekla.Properties.Resources.Shutdown16;
            this.mms_ssrv_shutdown.Name = "mms_ssrv_shutdown";
            resources.ApplyResources(this.mms_ssrv_shutdown, "mms_ssrv_shutdown");
            // 
            // mms_ssrv_dropdb
            // 
            this.mms_ssrv_dropdb.Image = global::Svekla.Properties.Resources.Warning16;
            this.mms_ssrv_dropdb.Name = "mms_ssrv_dropdb";
            resources.ApplyResources(this.mms_ssrv_dropdb, "mms_ssrv_dropdb");
            // 
            // mms_ssrv_dropall
            // 
            this.mms_ssrv_dropall.Image = global::Svekla.Properties.Resources.Warning16;
            this.mms_ssrv_dropall.Name = "mms_ssrv_dropall";
            resources.ApplyResources(this.mms_ssrv_dropall, "mms_ssrv_dropall");
            // 
            // mms_srv_sep1
            // 
            this.mms_srv_sep1.Name = "mms_srv_sep1";
            resources.ApplyResources(this.mms_srv_sep1, "mms_srv_sep1");
            // 
            // mms_srv_exitapp
            // 
            this.mms_srv_exitapp.Image = global::Svekla.Properties.Resources.Exit;
            this.mms_srv_exitapp.Name = "mms_srv_exitapp";
            resources.ApplyResources(this.mms_srv_exitapp, "mms_srv_exitapp");
            // 
            // mms_view
            // 
            this.mms_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_v_large,
            this.mms_v_small,
            this.mms_v_list,
            this.mms_v_details});
            this.mms_view.Name = "mms_view";
            resources.ApplyResources(this.mms_view, "mms_view");
            // 
            // mms_v_large
            // 
            this.mms_v_large.Image = global::Svekla.Properties.Resources.LargeIcons;
            this.mms_v_large.Name = "mms_v_large";
            resources.ApplyResources(this.mms_v_large, "mms_v_large");
            // 
            // mms_v_small
            // 
            this.mms_v_small.Image = global::Svekla.Properties.Resources.View16;
            this.mms_v_small.Name = "mms_v_small";
            resources.ApplyResources(this.mms_v_small, "mms_v_small");
            // 
            // mms_v_list
            // 
            this.mms_v_list.Image = global::Svekla.Properties.Resources.RedisList16;
            this.mms_v_list.Name = "mms_v_list";
            resources.ApplyResources(this.mms_v_list, "mms_v_list");
            // 
            // mms_v_details
            // 
            this.mms_v_details.Image = global::Svekla.Properties.Resources.Details16;
            this.mms_v_details.Name = "mms_v_details";
            resources.ApplyResources(this.mms_v_details, "mms_v_details");
            // 
            // mms_data
            // 
            this.mms_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_d_string,
            this.mms_d_list,
            this.mms_d_set,
            this.mms_d_zset,
            this.mms_d_hash,
            this.mms_v_sep0,
            this.mms_d_del});
            this.mms_data.Name = "mms_data";
            resources.ApplyResources(this.mms_data, "mms_data");
            // 
            // mms_d_string
            // 
            this.mms_d_string.Image = global::Svekla.Properties.Resources.RedisString16;
            this.mms_d_string.Name = "mms_d_string";
            resources.ApplyResources(this.mms_d_string, "mms_d_string");
            // 
            // mms_d_list
            // 
            this.mms_d_list.Image = global::Svekla.Properties.Resources.RedisList16;
            this.mms_d_list.Name = "mms_d_list";
            resources.ApplyResources(this.mms_d_list, "mms_d_list");
            // 
            // mms_d_set
            // 
            this.mms_d_set.Image = global::Svekla.Properties.Resources.RedisSet16;
            this.mms_d_set.Name = "mms_d_set";
            resources.ApplyResources(this.mms_d_set, "mms_d_set");
            // 
            // mms_d_zset
            // 
            this.mms_d_zset.Image = global::Svekla.Properties.Resources.RedisSortedSet16;
            this.mms_d_zset.Name = "mms_d_zset";
            resources.ApplyResources(this.mms_d_zset, "mms_d_zset");
            // 
            // mms_d_hash
            // 
            this.mms_d_hash.Image = global::Svekla.Properties.Resources.RedisHash16;
            this.mms_d_hash.Name = "mms_d_hash";
            resources.ApplyResources(this.mms_d_hash, "mms_d_hash");
            // 
            // mms_v_sep0
            // 
            this.mms_v_sep0.Name = "mms_v_sep0";
            resources.ApplyResources(this.mms_v_sep0, "mms_v_sep0");
            // 
            // mms_d_del
            // 
            this.mms_d_del.Name = "mms_d_del";
            resources.ApplyResources(this.mms_d_del, "mms_d_del");
            // 
            // mms_help
            // 
            this.mms_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSveklaToolStripMenuItem});
            this.mms_help.Name = "mms_help";
            resources.ApplyResources(this.mms_help, "mms_help");
            // 
            // aboutSveklaToolStripMenuItem
            // 
            this.aboutSveklaToolStripMenuItem.Image = global::Svekla.Properties.Resources.Info16;
            this.aboutSveklaToolStripMenuItem.Name = "aboutSveklaToolStripMenuItem";
            resources.ApplyResources(this.aboutSveklaToolStripMenuItem, "aboutSveklaToolStripMenuItem");
            this.aboutSveklaToolStripMenuItem.Click += new System.EventHandler(this.aboutSveklaToolStripMenuItem_Click);
            // 
            // mdiController
            // 
            this.mdiController.AutoScroll = false;
            this.mdiController.Image = global::Svekla.Properties.Resources.MdiBg;
            this.mdiController.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mdiController.ParentForm = this;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mms_program;
        private System.Windows.Forms.ToolStripMenuItem mms_srv_connect;
        private System.Windows.Forms.ToolStripMenuItem mms_help;
        private System.Windows.Forms.ToolStripSeparator mms_srv_sep0;
        private System.Windows.Forms.ToolStripMenuItem mms_ssrv_save;
        private System.Windows.Forms.ToolStripMenuItem mms_ssrv_bgsave;
        private System.Windows.Forms.ToolStripMenuItem mms_ssrv_shutdown;
        private System.Windows.Forms.ToolStripMenuItem mms_ssrv_dropdb;
        private System.Windows.Forms.ToolStripMenuItem mms_ssrv_dropall;
        private System.Windows.Forms.ToolStripSeparator mms_srv_sep1;
        private System.Windows.Forms.ToolStripMenuItem mms_srv_exitapp;
        private System.Windows.Forms.ToolStripMenuItem mms_data;
        private System.Windows.Forms.ToolStripMenuItem mms_d_string;
        private System.Windows.Forms.ToolStripMenuItem mms_d_list;
        private System.Windows.Forms.ToolStripMenuItem mms_d_set;
        private System.Windows.Forms.ToolStripMenuItem mms_d_zset;
        private System.Windows.Forms.ToolStripMenuItem mms_d_hash;
        private System.Windows.Forms.ToolStripSeparator mms_v_sep0;
        private System.Windows.Forms.ToolStripMenuItem mms_d_del;
        private System.Windows.Forms.ToolStripMenuItem aboutSveklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mms_view;
        private System.Windows.Forms.ToolStripMenuItem mms_v_large;
        private System.Windows.Forms.ToolStripMenuItem mms_v_small;
        private System.Windows.Forms.ToolStripMenuItem mms_v_list;
        private System.Windows.Forms.ToolStripMenuItem mms_v_details;
        private UI.Components.MdiClientController mdiController;
    }
}

