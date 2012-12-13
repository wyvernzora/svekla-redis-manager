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
            this.largeImgList = new System.Windows.Forms.ImageList(this.components);
            this.smallImgList = new System.Windows.Forms.ImageList(this.components);
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.olvcFileHandle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcAge = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcSub = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcPSub = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcMulti = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcQbuf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcQbufF = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcObl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcOll = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcOmem = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcEvents = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_c_kill = new System.Windows.Forms.ToolStripMenuItem();
            this.wsConnected = new Svekla.UI.Nightingale.WizardState();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.olvClients = new BrightIdeasSoftware.FastObjectListView();
            this.olvcAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcIdle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcFlags = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcDb = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcCmd = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSmServerName = new System.Windows.Forms.Label();
            this.lblSmVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSmDbSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSmMem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSmLastSave = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSmClients = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scRedisBrowserRoot = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.olvKeys = new BrightIdeasSoftware.VirtualObjectListView();
            this.olvcKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcTTL = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.cueTextBox1 = new Svekla.UI.Controls.CueTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.cmsClient.SuspendLayout();
            this.wsConnected.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvClients)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            // largeImgList
            // 
            this.largeImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImgList.ImageStream")));
            this.largeImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImgList.Images.SetKeyName(0, "String");
            this.largeImgList.Images.SetKeyName(1, "Hash");
            this.largeImgList.Images.SetKeyName(2, "List");
            this.largeImgList.Images.SetKeyName(3, "Set");
            this.largeImgList.Images.SetKeyName(4, "SortedSet");
            // 
            // smallImgList
            // 
            this.smallImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImgList.ImageStream")));
            this.smallImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImgList.Images.SetKeyName(0, "String");
            this.smallImgList.Images.SetKeyName(1, "Hash");
            this.smallImgList.Images.SetKeyName(2, "List");
            this.smallImgList.Images.SetKeyName(3, "Set");
            this.smallImgList.Images.SetKeyName(4, "SortedSet");
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // olvcFileHandle
            // 
            this.olvcFileHandle.AspectName = "FileDescriptor";
            resources.ApplyResources(this.olvcFileHandle, "olvcFileHandle");
            this.olvcFileHandle.IsVisible = false;
            // 
            // olvcAge
            // 
            this.olvcAge.AspectName = "Age";
            resources.ApplyResources(this.olvcAge, "olvcAge");
            this.olvcAge.IsVisible = false;
            // 
            // olvcSub
            // 
            this.olvcSub.AspectName = "Subscriptions";
            resources.ApplyResources(this.olvcSub, "olvcSub");
            this.olvcSub.IsVisible = false;
            // 
            // olvcPSub
            // 
            this.olvcPSub.AspectName = "PatternSubscriptions";
            resources.ApplyResources(this.olvcPSub, "olvcPSub");
            this.olvcPSub.IsVisible = false;
            // 
            // olvcMulti
            // 
            this.olvcMulti.AspectName = "MultiCommandCount";
            resources.ApplyResources(this.olvcMulti, "olvcMulti");
            this.olvcMulti.IsVisible = false;
            // 
            // olvcQbuf
            // 
            this.olvcQbuf.AspectName = "QueryBufferLength";
            resources.ApplyResources(this.olvcQbuf, "olvcQbuf");
            this.olvcQbuf.IsVisible = false;
            // 
            // olvcQbufF
            // 
            this.olvcQbufF.AspectName = "QueryBufferFree";
            resources.ApplyResources(this.olvcQbufF, "olvcQbufF");
            this.olvcQbufF.IsVisible = false;
            // 
            // olvcObl
            // 
            this.olvcObl.AspectName = "OutputBufferLength";
            resources.ApplyResources(this.olvcObl, "olvcObl");
            this.olvcObl.IsVisible = false;
            // 
            // olvcOll
            // 
            this.olvcOll.AspectName = "OutputListLength";
            resources.ApplyResources(this.olvcOll, "olvcOll");
            this.olvcOll.IsVisible = false;
            // 
            // olvcOmem
            // 
            this.olvcOmem.AspectName = "OutputBufferMemory";
            resources.ApplyResources(this.olvcOmem, "olvcOmem");
            this.olvcOmem.IsVisible = false;
            // 
            // olvcEvents
            // 
            this.olvcEvents.AspectName = "Events";
            resources.ApplyResources(this.olvcEvents, "olvcEvents");
            this.olvcEvents.IsVisible = false;
            // 
            // cmsClient
            // 
            this.cmsClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_c_kill});
            this.cmsClient.Name = "cmsClient";
            resources.ApplyResources(this.cmsClient, "cmsClient");
            // 
            // cms_c_kill
            // 
            this.cms_c_kill.Image = global::Svekla.Properties.Resources.Warning16;
            this.cms_c_kill.Name = "cms_c_kill";
            resources.ApplyResources(this.cms_c_kill, "cms_c_kill");
            this.cms_c_kill.Click += new System.EventHandler(this.cms_c_kill_Click);
            // 
            // wsConnected
            // 
            this.wsConnected.BackColor = System.Drawing.SystemColors.Control;
            this.wsConnected.Controls.Add(this.tabControl1);
            this.wsConnected.Controls.Add(this.statusStrip1);
            this.wsConnected.Controls.Add(this.dbg_lblwsConnected);
            resources.ApplyResources(this.wsConnected, "wsConnected");
            this.wsConnected.Name = "wsConnected";
            this.wsConnected.StateManager = null;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.olvClients);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // olvClients
            // 
            this.olvClients.AllColumns.Add(this.olvcAddress);
            this.olvClients.AllColumns.Add(this.olvcFileHandle);
            this.olvClients.AllColumns.Add(this.olvcAge);
            this.olvClients.AllColumns.Add(this.olvcIdle);
            this.olvClients.AllColumns.Add(this.olvcFlags);
            this.olvClients.AllColumns.Add(this.olvcDb);
            this.olvClients.AllColumns.Add(this.olvcSub);
            this.olvClients.AllColumns.Add(this.olvcPSub);
            this.olvClients.AllColumns.Add(this.olvcMulti);
            this.olvClients.AllColumns.Add(this.olvcQbuf);
            this.olvClients.AllColumns.Add(this.olvcQbufF);
            this.olvClients.AllColumns.Add(this.olvcObl);
            this.olvClients.AllColumns.Add(this.olvcOll);
            this.olvClients.AllColumns.Add(this.olvcOmem);
            this.olvClients.AllColumns.Add(this.olvcEvents);
            this.olvClients.AllColumns.Add(this.olvcCmd);
            this.olvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcAddress,
            this.olvcIdle,
            this.olvcFlags,
            this.olvcDb,
            this.olvcCmd});
            this.olvClients.ContextMenuStrip = this.cmsClient;
            resources.ApplyResources(this.olvClients, "olvClients");
            this.olvClients.FullRowSelect = true;
            this.olvClients.GridLines = true;
            this.olvClients.Name = "olvClients";
            this.olvClients.ShowGroups = false;
            this.olvClients.UseCompatibleStateImageBehavior = false;
            this.olvClients.View = System.Windows.Forms.View.Details;
            this.olvClients.VirtualMode = true;
            // 
            // olvcAddress
            // 
            this.olvcAddress.AspectName = "Address";
            this.olvcAddress.FillsFreeSpace = true;
            this.olvcAddress.MinimumWidth = 120;
            resources.ApplyResources(this.olvcAddress, "olvcAddress");
            // 
            // olvcIdle
            // 
            this.olvcIdle.AspectName = "IdleTime";
            resources.ApplyResources(this.olvcIdle, "olvcIdle");
            // 
            // olvcFlags
            // 
            this.olvcFlags.AspectName = "Flags";
            resources.ApplyResources(this.olvcFlags, "olvcFlags");
            // 
            // olvcDb
            // 
            this.olvcDb.AspectName = "DB";
            resources.ApplyResources(this.olvcDb, "olvcDb");
            // 
            // olvcCmd
            // 
            this.olvcCmd.AspectName = "LastCommand";
            resources.ApplyResources(this.olvcCmd, "olvcCmd");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSmServerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSmVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSmDbSize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSmMem, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSmLastSave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSmClients, 1, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblSmServerName
            // 
            resources.ApplyResources(this.lblSmServerName, "lblSmServerName");
            this.lblSmServerName.Name = "lblSmServerName";
            // 
            // lblSmVersion
            // 
            resources.ApplyResources(this.lblSmVersion, "lblSmVersion");
            this.lblSmVersion.Name = "lblSmVersion";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblSmDbSize
            // 
            resources.ApplyResources(this.lblSmDbSize, "lblSmDbSize");
            this.lblSmDbSize.Name = "lblSmDbSize";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblSmMem
            // 
            resources.ApplyResources(this.lblSmMem, "lblSmMem");
            this.lblSmMem.Name = "lblSmMem";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblSmLastSave
            // 
            resources.ApplyResources(this.lblSmLastSave, "lblSmLastSave");
            this.lblSmLastSave.Name = "lblSmLastSave";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // lblSmClients
            // 
            resources.ApplyResources(this.lblSmClients, "lblSmClients");
            this.lblSmClients.Name = "lblSmClients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Svekla.Properties.Resources.Свекла;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.scRedisBrowserRoot);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.olvKeys.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.olvKeys, "olvKeys");
            this.olvKeys.BackColor = System.Drawing.SystemColors.Window;
            this.olvKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcKey,
            this.olvcType,
            this.olvcTTL});
            this.olvKeys.FullRowSelect = true;
            this.olvKeys.LargeImageList = this.largeImgList;
            this.olvKeys.Name = "olvKeys";
            this.olvKeys.ShowGroups = false;
            this.olvKeys.SmallImageList = this.smallImgList;
            this.olvKeys.UseAlternatingBackColors = true;
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
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
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
            this.cmsClient.ResumeLayout(false);
            this.wsConnected.ResumeLayout(false);
            this.wsConnected.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvClients)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private UI.Controls.CueTextBox cueTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private UI.Nightingale.WizardState wsLoading;
        private UI.Controls.LoadingIndicator loadingIndicator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoadingProgressDetails;
        private System.Windows.Forms.ProgressBar pbLoadingProgress;
        private System.Windows.Forms.Label lblLoadingStatusTitle;
        private System.Windows.Forms.Button btnLoadingAbort;
        private System.Windows.Forms.ImageList largeImgList;
        private System.Windows.Forms.ImageList smallImgList;
        private BrightIdeasSoftware.VirtualObjectListView olvKeys;
        private BrightIdeasSoftware.OLVColumn olvcKey;
        private BrightIdeasSoftware.OLVColumn olvcType;
        private BrightIdeasSoftware.OLVColumn olvcTTL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSmServerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSmVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSmDbSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSmMem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSmLastSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSmClients;
        private System.Windows.Forms.GroupBox groupBox3;
        private BrightIdeasSoftware.FastObjectListView olvClients;
        private BrightIdeasSoftware.OLVColumn olvcAddress;
        private BrightIdeasSoftware.OLVColumn olvcFileHandle;
        private BrightIdeasSoftware.OLVColumn olvcAge;
        private BrightIdeasSoftware.OLVColumn olvcIdle;
        private BrightIdeasSoftware.OLVColumn olvcFlags;
        private BrightIdeasSoftware.OLVColumn olvcDb;
        private BrightIdeasSoftware.OLVColumn olvcSub;
        private BrightIdeasSoftware.OLVColumn olvcPSub;
        private BrightIdeasSoftware.OLVColumn olvcMulti;
        private BrightIdeasSoftware.OLVColumn olvcQbuf;
        private BrightIdeasSoftware.OLVColumn olvcQbufF;
        private BrightIdeasSoftware.OLVColumn olvcObl;
        private BrightIdeasSoftware.OLVColumn olvcOll;
        private BrightIdeasSoftware.OLVColumn olvcOmem;
        private BrightIdeasSoftware.OLVColumn olvcEvents;
        private BrightIdeasSoftware.OLVColumn olvcCmd;
        private System.Windows.Forms.ContextMenuStrip cmsClient;
        private System.Windows.Forms.ToolStripMenuItem cms_c_kill;
    }
}