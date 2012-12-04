namespace Svekla
{
    partial class RedisBrowserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedisBrowserForm));
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.largeImgList = new System.Windows.Forms.ImageList(this.components);
            this.smallImgList = new System.Windows.Forms.ImageList(this.components);
            this.wsConnected = new Svekla.UI.Nightingale.WizardState();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scRedisBrowserRoot = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.olvKeys = new BrightIdeasSoftware.VirtualObjectListView();
            this.olvcKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcTTL = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.cueTextBox1 = new Svekla.UI.Controls.CueTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbg_lblwsConnected = new System.Windows.Forms.Label();
            this.wsConnect = new Svekla.UI.Nightingale.WizardState();
            this.gbConnectInputs = new System.Windows.Forms.GroupBox();
            this.lblConnectionError = new System.Windows.Forms.Label();
            this.pbConnectLogo = new System.Windows.Forms.PictureBox();
            this.lblConnectTitle = new System.Windows.Forms.Label();
            this.btnCancelConnect = new System.Windows.Forms.Button();
            this.btnInitConnect = new System.Windows.Forms.Button();
            this.txtServerPassword = new Svekla.UI.Controls.CueTextBox();
            this.cmbServerAddress = new Svekla.UI.Controls.CueComboBox();
            this.dbg_lblwsConnect = new System.Windows.Forms.Label();
            this.wsLoading = new Svekla.UI.Nightingale.WizardState();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadingAbort = new System.Windows.Forms.Button();
            this.lblLoadingProgressDetails = new System.Windows.Forms.Label();
            this.pbLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.lblLoadingStatusTitle = new System.Windows.Forms.Label();
            this.loadingIndicator1 = new Svekla.UI.Controls.LoadingIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            this.wsConnected.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRedisBrowserRoot)).BeginInit();
            this.scRedisBrowserRoot.Panel1.SuspendLayout();
            this.scRedisBrowserRoot.Panel2.SuspendLayout();
            this.scRedisBrowserRoot.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvKeys)).BeginInit();
            this.wsConnect.SuspendLayout();
            this.gbConnectInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectLogo)).BeginInit();
            this.wsLoading.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // largeImgList
            // 
            this.largeImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImgList.ImageStream")));
            this.largeImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImgList.Images.SetKeyName(0, "Hash");
            this.largeImgList.Images.SetKeyName(1, "List");
            this.largeImgList.Images.SetKeyName(2, "Set");
            this.largeImgList.Images.SetKeyName(3, "SortedSet");
            this.largeImgList.Images.SetKeyName(4, "String");
            // 
            // smallImgList
            // 
            this.smallImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImgList.ImageStream")));
            this.smallImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImgList.Images.SetKeyName(0, "Hash");
            this.smallImgList.Images.SetKeyName(1, "List");
            this.smallImgList.Images.SetKeyName(2, "Set");
            this.smallImgList.Images.SetKeyName(3, "SortedSet");
            this.smallImgList.Images.SetKeyName(4, "String");
            // 
            // wsConnected
            // 
            this.wsConnected.BackColor = System.Drawing.Color.White;
            this.wsConnected.Controls.Add(this.toolStrip1);
            this.wsConnected.Controls.Add(this.scRedisBrowserRoot);
            this.wsConnected.Controls.Add(this.dbg_lblwsConnected);
            resources.ApplyResources(this.wsConnected, "wsConnected");
            this.wsConnected.Name = "wsConnected";
            this.wsConnected.StateManager = null;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.listToolStripMenuItem,
            this.hashToolStripMenuItem,
            this.setToolStripMenuItem,
            this.sortedSetToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Svekla.Properties.Resources.Add16;
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisString16;
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            resources.ApplyResources(this.stringToolStripMenuItem, "stringToolStripMenuItem");
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisList16;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            resources.ApplyResources(this.listToolStripMenuItem, "listToolStripMenuItem");
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisHash16;
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            resources.ApplyResources(this.hashToolStripMenuItem, "hashToolStripMenuItem");
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisSet16;
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            resources.ApplyResources(this.setToolStripMenuItem, "setToolStripMenuItem");
            // 
            // sortedSetToolStripMenuItem
            // 
            this.sortedSetToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisSortedSet16;
            this.sortedSetToolStripMenuItem.Name = "sortedSetToolStripMenuItem";
            resources.ApplyResources(this.sortedSetToolStripMenuItem, "sortedSetToolStripMenuItem");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Svekla.Properties.Resources.Remove16;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::Svekla.Properties.Resources.ViewMode16;
            resources.ApplyResources(this.toolStripDropDownButton2, "toolStripDropDownButton2");
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Image = global::Svekla.Properties.Resources.LargeIcons;
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            resources.ApplyResources(this.largeIconsToolStripMenuItem, "largeIconsToolStripMenuItem");
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Image = global::Svekla.Properties.Resources.View16;
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            resources.ApplyResources(this.smallIconsToolStripMenuItem, "smallIconsToolStripMenuItem");
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::Svekla.Properties.Resources.Details16;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            resources.ApplyResources(this.detailsToolStripMenuItem, "detailsToolStripMenuItem");
            // 
            // scRedisBrowserRoot
            // 
            resources.ApplyResources(this.scRedisBrowserRoot, "scRedisBrowserRoot");
            this.scRedisBrowserRoot.Name = "scRedisBrowserRoot";
            // 
            // scRedisBrowserRoot.Panel1
            // 
            this.scRedisBrowserRoot.Panel1.Controls.Add(this.groupBox2);
            // 
            // scRedisBrowserRoot.Panel2
            // 
            this.scRedisBrowserRoot.Panel2.Controls.Add(this.groupBox1);
            this.scRedisBrowserRoot.Panel2Collapsed = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.olvKeys);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cueTextBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // olvKeys
            // 
            this.olvKeys.AllColumns.Add(this.olvcKey);
            this.olvKeys.AllColumns.Add(this.olvcType);
            this.olvKeys.AllColumns.Add(this.olvcTTL);
            resources.ApplyResources(this.olvKeys, "olvKeys");
            this.olvKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcKey,
            this.olvcType,
            this.olvcTTL});
            this.olvKeys.FullRowSelect = true;
            this.olvKeys.GridLines = true;
            this.olvKeys.LargeImageList = this.largeImgList;
            this.olvKeys.Name = "olvKeys";
            this.olvKeys.ShowGroups = false;
            this.olvKeys.StateImageList = this.smallImgList;
            this.olvKeys.UseCompatibleStateImageBehavior = false;
            this.olvKeys.View = System.Windows.Forms.View.Details;
            this.olvKeys.VirtualMode = true;
            // 
            // olvcKey
            // 
            this.olvcKey.AspectName = "Key";
            this.olvcKey.FillsFreeSpace = true;
            resources.ApplyResources(this.olvcKey, "olvcKey");
            // 
            // olvcType
            // 
            this.olvcType.AspectName = "Type";
            resources.ApplyResources(this.olvcType, "olvcType");
            // 
            // olvcTTL
            // 
            this.olvcTTL.AspectName = "ExpiresAt";
            resources.ApplyResources(this.olvcTTL, "olvcTTL");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cueTextBox1
            // 
            resources.ApplyResources(this.cueTextBox1, "cueTextBox1");
            this.cueTextBox1.Name = "cueTextBox1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dbg_lblwsConnected
            // 
            resources.ApplyResources(this.dbg_lblwsConnected, "dbg_lblwsConnected");
            this.dbg_lblwsConnected.Name = "dbg_lblwsConnected";
            // 
            // wsConnect
            // 
            this.wsConnect.BackColor = System.Drawing.Color.White;
            this.wsConnect.Controls.Add(this.gbConnectInputs);
            this.wsConnect.Controls.Add(this.dbg_lblwsConnect);
            resources.ApplyResources(this.wsConnect, "wsConnect");
            this.wsConnect.Name = "wsConnect";
            this.wsConnect.StateManager = null;
            // 
            // gbConnectInputs
            // 
            resources.ApplyResources(this.gbConnectInputs, "gbConnectInputs");
            this.gbConnectInputs.Controls.Add(this.lblConnectionError);
            this.gbConnectInputs.Controls.Add(this.pbConnectLogo);
            this.gbConnectInputs.Controls.Add(this.lblConnectTitle);
            this.gbConnectInputs.Controls.Add(this.btnCancelConnect);
            this.gbConnectInputs.Controls.Add(this.btnInitConnect);
            this.gbConnectInputs.Controls.Add(this.txtServerPassword);
            this.gbConnectInputs.Controls.Add(this.cmbServerAddress);
            this.gbConnectInputs.Name = "gbConnectInputs";
            this.gbConnectInputs.TabStop = false;
            // 
            // lblConnectionError
            // 
            resources.ApplyResources(this.lblConnectionError, "lblConnectionError");
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Name = "lblConnectionError";
            // 
            // pbConnectLogo
            // 
            resources.ApplyResources(this.pbConnectLogo, "pbConnectLogo");
            this.pbConnectLogo.Image = global::Svekla.Properties.Resources.hm_redis_connect;
            this.pbConnectLogo.Name = "pbConnectLogo";
            this.pbConnectLogo.TabStop = false;
            // 
            // lblConnectTitle
            // 
            resources.ApplyResources(this.lblConnectTitle, "lblConnectTitle");
            this.lblConnectTitle.Name = "lblConnectTitle";
            // 
            // btnCancelConnect
            // 
            resources.ApplyResources(this.btnCancelConnect, "btnCancelConnect");
            this.btnCancelConnect.Name = "btnCancelConnect";
            this.btnCancelConnect.UseVisualStyleBackColor = true;
            // 
            // btnInitConnect
            // 
            resources.ApplyResources(this.btnInitConnect, "btnInitConnect");
            this.btnInitConnect.Name = "btnInitConnect";
            this.btnInitConnect.UseVisualStyleBackColor = true;
            this.btnInitConnect.Click += new System.EventHandler(this.btnInitConnect_Click);
            // 
            // txtServerPassword
            // 
            resources.ApplyResources(this.txtServerPassword, "txtServerPassword");
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // cmbServerAddress
            // 
            resources.ApplyResources(this.cmbServerAddress, "cmbServerAddress");
            this.cmbServerAddress.FormattingEnabled = true;
            this.cmbServerAddress.Name = "cmbServerAddress";
            // 
            // dbg_lblwsConnect
            // 
            resources.ApplyResources(this.dbg_lblwsConnect, "dbg_lblwsConnect");
            this.dbg_lblwsConnect.Name = "dbg_lblwsConnect";
            // 
            // wsLoading
            // 
            this.wsLoading.BackColor = System.Drawing.Color.White;
            this.wsLoading.Controls.Add(this.panel1);
            resources.ApplyResources(this.wsLoading, "wsLoading");
            this.wsLoading.Name = "wsLoading";
            this.wsLoading.StateManager = null;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnLoadingAbort);
            this.panel1.Controls.Add(this.lblLoadingProgressDetails);
            this.panel1.Controls.Add(this.pbLoadingProgress);
            this.panel1.Controls.Add(this.lblLoadingStatusTitle);
            this.panel1.Controls.Add(this.loadingIndicator1);
            this.panel1.Name = "panel1";
            // 
            // btnLoadingAbort
            // 
            resources.ApplyResources(this.btnLoadingAbort, "btnLoadingAbort");
            this.btnLoadingAbort.Name = "btnLoadingAbort";
            this.btnLoadingAbort.UseVisualStyleBackColor = true;
            this.btnLoadingAbort.Click += new System.EventHandler(this.btnLoadingAbort_Click);
            // 
            // lblLoadingProgressDetails
            // 
            resources.ApplyResources(this.lblLoadingProgressDetails, "lblLoadingProgressDetails");
            this.lblLoadingProgressDetails.Name = "lblLoadingProgressDetails";
            // 
            // pbLoadingProgress
            // 
            resources.ApplyResources(this.pbLoadingProgress, "pbLoadingProgress");
            this.pbLoadingProgress.Name = "pbLoadingProgress";
            // 
            // lblLoadingStatusTitle
            // 
            resources.ApplyResources(this.lblLoadingStatusTitle, "lblLoadingStatusTitle");
            this.lblLoadingStatusTitle.Name = "lblLoadingStatusTitle";
            // 
            // loadingIndicator1
            // 
            resources.ApplyResources(this.loadingIndicator1, "loadingIndicator1");
            this.loadingIndicator1.Name = "loadingIndicator1";
            // 
            // RedisBrowserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wsConnected);
            this.Controls.Add(this.wsConnect);
            this.Controls.Add(this.wsLoading);
            this.Name = "RedisBrowserForm";
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.wsConnected.ResumeLayout(false);
            this.wsConnected.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.scRedisBrowserRoot.Panel1.ResumeLayout(false);
            this.scRedisBrowserRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRedisBrowserRoot)).EndInit();
            this.scRedisBrowserRoot.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvKeys)).EndInit();
            this.wsConnect.ResumeLayout(false);
            this.wsConnect.PerformLayout();
            this.gbConnectInputs.ResumeLayout(false);
            this.gbConnectInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectLogo)).EndInit();
            this.wsLoading.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Nightingale.WizardState wsConnect;
        private UI.Nightingale.WizardState wsConnected;
        private System.Windows.Forms.Label dbg_lblwsConnect;
        private System.Windows.Forms.Label dbg_lblwsConnected;
        private System.Windows.Forms.PictureBox pbConnectLogo;
        private System.Windows.Forms.Label lblConnectTitle;
        private System.Windows.Forms.GroupBox gbConnectInputs;
        private UI.Controls.CueTextBox txtServerPassword;
        private UI.Controls.CueComboBox cmbServerAddress;
        private System.Windows.Forms.Button btnCancelConnect;
        private System.Windows.Forms.Button btnInitConnect;
        private System.Windows.Forms.ErrorProvider errors;
        private System.Windows.Forms.Label lblConnectionError;
        private System.Windows.Forms.SplitContainer scRedisBrowserRoot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private UI.Controls.CueTextBox cueTextBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private UI.Nightingale.WizardState wsLoading;
        private UI.Controls.LoadingIndicator loadingIndicator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoadingProgressDetails;
        private System.Windows.Forms.ProgressBar pbLoadingProgress;
        private System.Windows.Forms.Label lblLoadingStatusTitle;
        private System.Windows.Forms.Button btnLoadingAbort;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ImageList largeImgList;
        private System.Windows.Forms.ImageList smallImgList;
        private BrightIdeasSoftware.VirtualObjectListView olvKeys;
        private BrightIdeasSoftware.OLVColumn olvcKey;
        private BrightIdeasSoftware.OLVColumn olvcType;
        private BrightIdeasSoftware.OLVColumn olvcTTL;
    }
}