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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.wsConnected = new Svekla.UI.Nightingale.WizardState();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.wsConnected.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            resources.ApplyResources(this.errors, "errors");
            // 
            // wsConnected
            // 
            resources.ApplyResources(this.wsConnected, "wsConnected");
            this.wsConnected.BackColor = System.Drawing.SystemColors.Control;
            this.wsConnected.Controls.Add(this.tabControl1);
            this.wsConnected.Controls.Add(this.statusStrip1);
            this.wsConnected.Controls.Add(this.dbg_lblwsConnected);
            this.errors.SetError(this.wsConnected, resources.GetString("wsConnected.Error"));
            this.errors.SetIconAlignment(this.wsConnected, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("wsConnected.IconAlignment"))));
            this.errors.SetIconPadding(this.wsConnected, ((int)(resources.GetObject("wsConnected.IconPadding"))));
            this.wsConnected.Name = "wsConnected";
            this.wsConnected.StateManager = null;
            this.toolTip1.SetToolTip(this.wsConnected, resources.GetString("wsConnected.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.errors.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errors.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errors.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.errors.SetError(this.tabPage1, resources.GetString("tabPage1.Error"));
            this.errors.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment"))));
            this.errors.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding"))));
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.errors.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errors.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errors.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
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
            this.errors.SetError(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error"));
            this.errors.SetIconAlignment(this.tableLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tableLayoutPanel1.IconAlignment"))));
            this.errors.SetIconPadding(this.tableLayoutPanel1, ((int)(resources.GetObject("tableLayoutPanel1.IconPadding"))));
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errors.SetError(this.label1, resources.GetString("label1.Error"));
            this.errors.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errors.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblSmServerName
            // 
            resources.ApplyResources(this.lblSmServerName, "lblSmServerName");
            this.errors.SetError(this.lblSmServerName, resources.GetString("lblSmServerName.Error"));
            this.errors.SetIconAlignment(this.lblSmServerName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmServerName.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmServerName, ((int)(resources.GetObject("lblSmServerName.IconPadding"))));
            this.lblSmServerName.Name = "lblSmServerName";
            this.toolTip1.SetToolTip(this.lblSmServerName, resources.GetString("lblSmServerName.ToolTip"));
            // 
            // lblSmVersion
            // 
            resources.ApplyResources(this.lblSmVersion, "lblSmVersion");
            this.errors.SetError(this.lblSmVersion, resources.GetString("lblSmVersion.Error"));
            this.errors.SetIconAlignment(this.lblSmVersion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmVersion.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmVersion, ((int)(resources.GetObject("lblSmVersion.IconPadding"))));
            this.lblSmVersion.Name = "lblSmVersion";
            this.toolTip1.SetToolTip(this.lblSmVersion, resources.GetString("lblSmVersion.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errors.SetError(this.label3, resources.GetString("label3.Error"));
            this.errors.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errors.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // lblSmDbSize
            // 
            resources.ApplyResources(this.lblSmDbSize, "lblSmDbSize");
            this.errors.SetError(this.lblSmDbSize, resources.GetString("lblSmDbSize.Error"));
            this.errors.SetIconAlignment(this.lblSmDbSize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmDbSize.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmDbSize, ((int)(resources.GetObject("lblSmDbSize.IconPadding"))));
            this.lblSmDbSize.Name = "lblSmDbSize";
            this.toolTip1.SetToolTip(this.lblSmDbSize, resources.GetString("lblSmDbSize.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errors.SetError(this.label5, resources.GetString("label5.Error"));
            this.errors.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errors.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // lblSmMem
            // 
            resources.ApplyResources(this.lblSmMem, "lblSmMem");
            this.errors.SetError(this.lblSmMem, resources.GetString("lblSmMem.Error"));
            this.errors.SetIconAlignment(this.lblSmMem, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmMem.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmMem, ((int)(resources.GetObject("lblSmMem.IconPadding"))));
            this.lblSmMem.Name = "lblSmMem";
            this.toolTip1.SetToolTip(this.lblSmMem, resources.GetString("lblSmMem.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errors.SetError(this.label7, resources.GetString("label7.Error"));
            this.errors.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errors.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // lblSmLastSave
            // 
            resources.ApplyResources(this.lblSmLastSave, "lblSmLastSave");
            this.errors.SetError(this.lblSmLastSave, resources.GetString("lblSmLastSave.Error"));
            this.errors.SetIconAlignment(this.lblSmLastSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmLastSave.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmLastSave, ((int)(resources.GetObject("lblSmLastSave.IconPadding"))));
            this.lblSmLastSave.Name = "lblSmLastSave";
            this.toolTip1.SetToolTip(this.lblSmLastSave, resources.GetString("lblSmLastSave.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errors.SetError(this.label9, resources.GetString("label9.Error"));
            this.errors.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errors.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // lblSmClients
            // 
            resources.ApplyResources(this.lblSmClients, "lblSmClients");
            this.errors.SetError(this.lblSmClients, resources.GetString("lblSmClients.Error"));
            this.errors.SetIconAlignment(this.lblSmClients, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSmClients.IconAlignment"))));
            this.errors.SetIconPadding(this.lblSmClients, ((int)(resources.GetObject("lblSmClients.IconPadding"))));
            this.lblSmClients.Name = "lblSmClients";
            this.toolTip1.SetToolTip(this.lblSmClients, resources.GetString("lblSmClients.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.errors.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errors.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errors.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::Svekla.Properties.Resources.Свекла;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.scRedisBrowserRoot);
            this.errors.SetError(this.tabPage2, resources.GetString("tabPage2.Error"));
            this.errors.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment"))));
            this.errors.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding"))));
            this.tabPage2.Name = "tabPage2";
            this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.errors.SetError(this.toolStrip1, resources.GetString("toolStrip1.Error"));
            this.errors.SetIconAlignment(this.toolStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStrip1.IconAlignment"))));
            this.errors.SetIconPadding(this.toolStrip1, ((int)(resources.GetObject("toolStrip1.IconPadding"))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Name = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.listToolStripMenuItem,
            this.hashToolStripMenuItem,
            this.setToolStripMenuItem,
            this.sortedSetToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Svekla.Properties.Resources.Add16;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // stringToolStripMenuItem
            // 
            resources.ApplyResources(this.stringToolStripMenuItem, "stringToolStripMenuItem");
            this.stringToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisString16;
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            // 
            // listToolStripMenuItem
            // 
            resources.ApplyResources(this.listToolStripMenuItem, "listToolStripMenuItem");
            this.listToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisList16;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            // 
            // hashToolStripMenuItem
            // 
            resources.ApplyResources(this.hashToolStripMenuItem, "hashToolStripMenuItem");
            this.hashToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisHash16;
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            // 
            // setToolStripMenuItem
            // 
            resources.ApplyResources(this.setToolStripMenuItem, "setToolStripMenuItem");
            this.setToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisSet16;
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            // 
            // sortedSetToolStripMenuItem
            // 
            resources.ApplyResources(this.sortedSetToolStripMenuItem, "sortedSetToolStripMenuItem");
            this.sortedSetToolStripMenuItem.Image = global::Svekla.Properties.Resources.RedisSortedSet16;
            this.sortedSetToolStripMenuItem.Name = "sortedSetToolStripMenuItem";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Image = global::Svekla.Properties.Resources.Remove16;
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripDropDownButton2
            // 
            resources.ApplyResources(this.toolStripDropDownButton2, "toolStripDropDownButton2");
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::Svekla.Properties.Resources.ViewMode16;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            // 
            // largeIconsToolStripMenuItem
            // 
            resources.ApplyResources(this.largeIconsToolStripMenuItem, "largeIconsToolStripMenuItem");
            this.largeIconsToolStripMenuItem.Image = global::Svekla.Properties.Resources.LargeIcons;
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.changeView);
            // 
            // smallIconsToolStripMenuItem
            // 
            resources.ApplyResources(this.smallIconsToolStripMenuItem, "smallIconsToolStripMenuItem");
            this.smallIconsToolStripMenuItem.Image = global::Svekla.Properties.Resources.View16;
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.changeView);
            // 
            // detailsToolStripMenuItem
            // 
            resources.ApplyResources(this.detailsToolStripMenuItem, "detailsToolStripMenuItem");
            this.detailsToolStripMenuItem.Image = global::Svekla.Properties.Resources.Details16;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.changeView);
            // 
            // scRedisBrowserRoot
            // 
            resources.ApplyResources(this.scRedisBrowserRoot, "scRedisBrowserRoot");
            this.errors.SetError(this.scRedisBrowserRoot, resources.GetString("scRedisBrowserRoot.Error"));
            this.errors.SetIconAlignment(this.scRedisBrowserRoot, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("scRedisBrowserRoot.IconAlignment"))));
            this.errors.SetIconPadding(this.scRedisBrowserRoot, ((int)(resources.GetObject("scRedisBrowserRoot.IconPadding"))));
            this.scRedisBrowserRoot.Name = "scRedisBrowserRoot";
            // 
            // scRedisBrowserRoot.Panel1
            // 
            resources.ApplyResources(this.scRedisBrowserRoot.Panel1, "scRedisBrowserRoot.Panel1");
            this.scRedisBrowserRoot.Panel1.Controls.Add(this.groupBox2);
            this.errors.SetError(this.scRedisBrowserRoot.Panel1, resources.GetString("scRedisBrowserRoot.Panel1.Error"));
            this.errors.SetIconAlignment(this.scRedisBrowserRoot.Panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("scRedisBrowserRoot.Panel1.IconAlignment"))));
            this.errors.SetIconPadding(this.scRedisBrowserRoot.Panel1, ((int)(resources.GetObject("scRedisBrowserRoot.Panel1.IconPadding"))));
            this.toolTip1.SetToolTip(this.scRedisBrowserRoot.Panel1, resources.GetString("scRedisBrowserRoot.Panel1.ToolTip"));
            // 
            // scRedisBrowserRoot.Panel2
            // 
            resources.ApplyResources(this.scRedisBrowserRoot.Panel2, "scRedisBrowserRoot.Panel2");
            this.scRedisBrowserRoot.Panel2.Controls.Add(this.groupBox1);
            this.errors.SetError(this.scRedisBrowserRoot.Panel2, resources.GetString("scRedisBrowserRoot.Panel2.Error"));
            this.errors.SetIconAlignment(this.scRedisBrowserRoot.Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("scRedisBrowserRoot.Panel2.IconAlignment"))));
            this.errors.SetIconPadding(this.scRedisBrowserRoot.Panel2, ((int)(resources.GetObject("scRedisBrowserRoot.Panel2.IconPadding"))));
            this.toolTip1.SetToolTip(this.scRedisBrowserRoot.Panel2, resources.GetString("scRedisBrowserRoot.Panel2.ToolTip"));
            this.scRedisBrowserRoot.Panel2Collapsed = true;
            this.toolTip1.SetToolTip(this.scRedisBrowserRoot, resources.GetString("scRedisBrowserRoot.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.olvKeys);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cueTextBox1);
            this.errors.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errors.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errors.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // olvKeys
            // 
            resources.ApplyResources(this.olvKeys, "olvKeys");
            this.olvKeys.AllColumns.Add(this.olvcKey);
            this.olvKeys.AllColumns.Add(this.olvcType);
            this.olvKeys.AllColumns.Add(this.olvcTTL);
            this.olvKeys.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvKeys.BackColor = System.Drawing.SystemColors.Window;
            this.olvKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcKey,
            this.olvcType,
            this.olvcTTL});
            this.errors.SetError(this.olvKeys, resources.GetString("olvKeys.Error"));
            this.olvKeys.FullRowSelect = true;
            this.errors.SetIconAlignment(this.olvKeys, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("olvKeys.IconAlignment"))));
            this.errors.SetIconPadding(this.olvKeys, ((int)(resources.GetObject("olvKeys.IconPadding"))));
            this.olvKeys.LargeImageList = this.largeImgList;
            this.olvKeys.Name = "olvKeys";
            this.olvKeys.OverlayText.Text = resources.GetString("resource.Text");
            this.olvKeys.ShowGroups = false;
            this.olvKeys.SmallImageList = this.smallImgList;
            this.toolTip1.SetToolTip(this.olvKeys, resources.GetString("olvKeys.ToolTip"));
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
            this.errors.SetError(this.button1, resources.GetString("button1.Error"));
            this.errors.SetIconAlignment(this.button1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button1.IconAlignment"))));
            this.errors.SetIconPadding(this.button1, ((int)(resources.GetObject("button1.IconPadding"))));
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cueTextBox1
            // 
            resources.ApplyResources(this.cueTextBox1, "cueTextBox1");
            this.errors.SetError(this.cueTextBox1, resources.GetString("cueTextBox1.Error"));
            this.errors.SetIconAlignment(this.cueTextBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cueTextBox1.IconAlignment"))));
            this.errors.SetIconPadding(this.cueTextBox1, ((int)(resources.GetObject("cueTextBox1.IconPadding"))));
            this.cueTextBox1.Name = "cueTextBox1";
            this.toolTip1.SetToolTip(this.cueTextBox1, resources.GetString("cueTextBox1.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.errors.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errors.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errors.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.errors.SetError(this.statusStrip1, resources.GetString("statusStrip1.Error"));
            this.errors.SetIconAlignment(this.statusStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("statusStrip1.IconAlignment"))));
            this.errors.SetIconPadding(this.statusStrip1, ((int)(resources.GetObject("statusStrip1.IconPadding"))));
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // dbg_lblwsConnected
            // 
            resources.ApplyResources(this.dbg_lblwsConnected, "dbg_lblwsConnected");
            this.errors.SetError(this.dbg_lblwsConnected, resources.GetString("dbg_lblwsConnected.Error"));
            this.errors.SetIconAlignment(this.dbg_lblwsConnected, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dbg_lblwsConnected.IconAlignment"))));
            this.errors.SetIconPadding(this.dbg_lblwsConnected, ((int)(resources.GetObject("dbg_lblwsConnected.IconPadding"))));
            this.dbg_lblwsConnected.Name = "dbg_lblwsConnected";
            this.toolTip1.SetToolTip(this.dbg_lblwsConnected, resources.GetString("dbg_lblwsConnected.ToolTip"));
            // 
            // wsConnect
            // 
            resources.ApplyResources(this.wsConnect, "wsConnect");
            this.wsConnect.BackColor = System.Drawing.Color.White;
            this.wsConnect.Controls.Add(this.gbConnectInputs);
            this.wsConnect.Controls.Add(this.dbg_lblwsConnect);
            this.errors.SetError(this.wsConnect, resources.GetString("wsConnect.Error"));
            this.errors.SetIconAlignment(this.wsConnect, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("wsConnect.IconAlignment"))));
            this.errors.SetIconPadding(this.wsConnect, ((int)(resources.GetObject("wsConnect.IconPadding"))));
            this.wsConnect.Name = "wsConnect";
            this.wsConnect.StateManager = null;
            this.toolTip1.SetToolTip(this.wsConnect, resources.GetString("wsConnect.ToolTip"));
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
            this.errors.SetError(this.gbConnectInputs, resources.GetString("gbConnectInputs.Error"));
            this.errors.SetIconAlignment(this.gbConnectInputs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbConnectInputs.IconAlignment"))));
            this.errors.SetIconPadding(this.gbConnectInputs, ((int)(resources.GetObject("gbConnectInputs.IconPadding"))));
            this.gbConnectInputs.Name = "gbConnectInputs";
            this.gbConnectInputs.TabStop = false;
            this.toolTip1.SetToolTip(this.gbConnectInputs, resources.GetString("gbConnectInputs.ToolTip"));
            // 
            // lblConnectionError
            // 
            resources.ApplyResources(this.lblConnectionError, "lblConnectionError");
            this.errors.SetError(this.lblConnectionError, resources.GetString("lblConnectionError.Error"));
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.errors.SetIconAlignment(this.lblConnectionError, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblConnectionError.IconAlignment"))));
            this.errors.SetIconPadding(this.lblConnectionError, ((int)(resources.GetObject("lblConnectionError.IconPadding"))));
            this.lblConnectionError.Name = "lblConnectionError";
            this.toolTip1.SetToolTip(this.lblConnectionError, resources.GetString("lblConnectionError.ToolTip"));
            // 
            // pbConnectLogo
            // 
            resources.ApplyResources(this.pbConnectLogo, "pbConnectLogo");
            this.errors.SetError(this.pbConnectLogo, resources.GetString("pbConnectLogo.Error"));
            this.errors.SetIconAlignment(this.pbConnectLogo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbConnectLogo.IconAlignment"))));
            this.errors.SetIconPadding(this.pbConnectLogo, ((int)(resources.GetObject("pbConnectLogo.IconPadding"))));
            this.pbConnectLogo.Image = global::Svekla.Properties.Resources.hm_redis_connect;
            this.pbConnectLogo.Name = "pbConnectLogo";
            this.pbConnectLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.pbConnectLogo, resources.GetString("pbConnectLogo.ToolTip"));
            // 
            // lblConnectTitle
            // 
            resources.ApplyResources(this.lblConnectTitle, "lblConnectTitle");
            this.errors.SetError(this.lblConnectTitle, resources.GetString("lblConnectTitle.Error"));
            this.errors.SetIconAlignment(this.lblConnectTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblConnectTitle.IconAlignment"))));
            this.errors.SetIconPadding(this.lblConnectTitle, ((int)(resources.GetObject("lblConnectTitle.IconPadding"))));
            this.lblConnectTitle.Name = "lblConnectTitle";
            this.toolTip1.SetToolTip(this.lblConnectTitle, resources.GetString("lblConnectTitle.ToolTip"));
            // 
            // btnCancelConnect
            // 
            resources.ApplyResources(this.btnCancelConnect, "btnCancelConnect");
            this.errors.SetError(this.btnCancelConnect, resources.GetString("btnCancelConnect.Error"));
            this.errors.SetIconAlignment(this.btnCancelConnect, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancelConnect.IconAlignment"))));
            this.errors.SetIconPadding(this.btnCancelConnect, ((int)(resources.GetObject("btnCancelConnect.IconPadding"))));
            this.btnCancelConnect.Name = "btnCancelConnect";
            this.toolTip1.SetToolTip(this.btnCancelConnect, resources.GetString("btnCancelConnect.ToolTip"));
            this.btnCancelConnect.UseVisualStyleBackColor = true;
            // 
            // btnInitConnect
            // 
            resources.ApplyResources(this.btnInitConnect, "btnInitConnect");
            this.errors.SetError(this.btnInitConnect, resources.GetString("btnInitConnect.Error"));
            this.errors.SetIconAlignment(this.btnInitConnect, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnInitConnect.IconAlignment"))));
            this.errors.SetIconPadding(this.btnInitConnect, ((int)(resources.GetObject("btnInitConnect.IconPadding"))));
            this.btnInitConnect.Name = "btnInitConnect";
            this.toolTip1.SetToolTip(this.btnInitConnect, resources.GetString("btnInitConnect.ToolTip"));
            this.btnInitConnect.UseVisualStyleBackColor = true;
            this.btnInitConnect.Click += new System.EventHandler(this.btnInitConnect_Click);
            // 
            // txtServerPassword
            // 
            resources.ApplyResources(this.txtServerPassword, "txtServerPassword");
            this.errors.SetError(this.txtServerPassword, resources.GetString("txtServerPassword.Error"));
            this.errors.SetIconAlignment(this.txtServerPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtServerPassword.IconAlignment"))));
            this.errors.SetIconPadding(this.txtServerPassword, ((int)(resources.GetObject("txtServerPassword.IconPadding"))));
            this.txtServerPassword.Name = "txtServerPassword";
            this.toolTip1.SetToolTip(this.txtServerPassword, resources.GetString("txtServerPassword.ToolTip"));
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // cmbServerAddress
            // 
            resources.ApplyResources(this.cmbServerAddress, "cmbServerAddress");
            this.errors.SetError(this.cmbServerAddress, resources.GetString("cmbServerAddress.Error"));
            this.cmbServerAddress.FormattingEnabled = true;
            this.errors.SetIconAlignment(this.cmbServerAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbServerAddress.IconAlignment"))));
            this.errors.SetIconPadding(this.cmbServerAddress, ((int)(resources.GetObject("cmbServerAddress.IconPadding"))));
            this.cmbServerAddress.Name = "cmbServerAddress";
            this.toolTip1.SetToolTip(this.cmbServerAddress, resources.GetString("cmbServerAddress.ToolTip"));
            // 
            // dbg_lblwsConnect
            // 
            resources.ApplyResources(this.dbg_lblwsConnect, "dbg_lblwsConnect");
            this.errors.SetError(this.dbg_lblwsConnect, resources.GetString("dbg_lblwsConnect.Error"));
            this.errors.SetIconAlignment(this.dbg_lblwsConnect, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dbg_lblwsConnect.IconAlignment"))));
            this.errors.SetIconPadding(this.dbg_lblwsConnect, ((int)(resources.GetObject("dbg_lblwsConnect.IconPadding"))));
            this.dbg_lblwsConnect.Name = "dbg_lblwsConnect";
            this.toolTip1.SetToolTip(this.dbg_lblwsConnect, resources.GetString("dbg_lblwsConnect.ToolTip"));
            // 
            // wsLoading
            // 
            resources.ApplyResources(this.wsLoading, "wsLoading");
            this.wsLoading.BackColor = System.Drawing.Color.White;
            this.wsLoading.Controls.Add(this.panel1);
            this.errors.SetError(this.wsLoading, resources.GetString("wsLoading.Error"));
            this.errors.SetIconAlignment(this.wsLoading, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("wsLoading.IconAlignment"))));
            this.errors.SetIconPadding(this.wsLoading, ((int)(resources.GetObject("wsLoading.IconPadding"))));
            this.wsLoading.Name = "wsLoading";
            this.wsLoading.StateManager = null;
            this.toolTip1.SetToolTip(this.wsLoading, resources.GetString("wsLoading.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnLoadingAbort);
            this.panel1.Controls.Add(this.lblLoadingProgressDetails);
            this.panel1.Controls.Add(this.pbLoadingProgress);
            this.panel1.Controls.Add(this.lblLoadingStatusTitle);
            this.panel1.Controls.Add(this.loadingIndicator1);
            this.errors.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errors.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errors.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // btnLoadingAbort
            // 
            resources.ApplyResources(this.btnLoadingAbort, "btnLoadingAbort");
            this.errors.SetError(this.btnLoadingAbort, resources.GetString("btnLoadingAbort.Error"));
            this.errors.SetIconAlignment(this.btnLoadingAbort, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnLoadingAbort.IconAlignment"))));
            this.errors.SetIconPadding(this.btnLoadingAbort, ((int)(resources.GetObject("btnLoadingAbort.IconPadding"))));
            this.btnLoadingAbort.Name = "btnLoadingAbort";
            this.toolTip1.SetToolTip(this.btnLoadingAbort, resources.GetString("btnLoadingAbort.ToolTip"));
            this.btnLoadingAbort.UseVisualStyleBackColor = true;
            this.btnLoadingAbort.Click += new System.EventHandler(this.btnLoadingAbort_Click);
            // 
            // lblLoadingProgressDetails
            // 
            resources.ApplyResources(this.lblLoadingProgressDetails, "lblLoadingProgressDetails");
            this.errors.SetError(this.lblLoadingProgressDetails, resources.GetString("lblLoadingProgressDetails.Error"));
            this.errors.SetIconAlignment(this.lblLoadingProgressDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLoadingProgressDetails.IconAlignment"))));
            this.errors.SetIconPadding(this.lblLoadingProgressDetails, ((int)(resources.GetObject("lblLoadingProgressDetails.IconPadding"))));
            this.lblLoadingProgressDetails.Name = "lblLoadingProgressDetails";
            this.toolTip1.SetToolTip(this.lblLoadingProgressDetails, resources.GetString("lblLoadingProgressDetails.ToolTip"));
            // 
            // pbLoadingProgress
            // 
            resources.ApplyResources(this.pbLoadingProgress, "pbLoadingProgress");
            this.errors.SetError(this.pbLoadingProgress, resources.GetString("pbLoadingProgress.Error"));
            this.errors.SetIconAlignment(this.pbLoadingProgress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbLoadingProgress.IconAlignment"))));
            this.errors.SetIconPadding(this.pbLoadingProgress, ((int)(resources.GetObject("pbLoadingProgress.IconPadding"))));
            this.pbLoadingProgress.Name = "pbLoadingProgress";
            this.toolTip1.SetToolTip(this.pbLoadingProgress, resources.GetString("pbLoadingProgress.ToolTip"));
            // 
            // lblLoadingStatusTitle
            // 
            resources.ApplyResources(this.lblLoadingStatusTitle, "lblLoadingStatusTitle");
            this.errors.SetError(this.lblLoadingStatusTitle, resources.GetString("lblLoadingStatusTitle.Error"));
            this.errors.SetIconAlignment(this.lblLoadingStatusTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLoadingStatusTitle.IconAlignment"))));
            this.errors.SetIconPadding(this.lblLoadingStatusTitle, ((int)(resources.GetObject("lblLoadingStatusTitle.IconPadding"))));
            this.lblLoadingStatusTitle.Name = "lblLoadingStatusTitle";
            this.toolTip1.SetToolTip(this.lblLoadingStatusTitle, resources.GetString("lblLoadingStatusTitle.ToolTip"));
            // 
            // loadingIndicator1
            // 
            resources.ApplyResources(this.loadingIndicator1, "loadingIndicator1");
            this.errors.SetError(this.loadingIndicator1, resources.GetString("loadingIndicator1.Error"));
            this.errors.SetIconAlignment(this.loadingIndicator1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("loadingIndicator1.IconAlignment"))));
            this.errors.SetIconPadding(this.loadingIndicator1, ((int)(resources.GetObject("loadingIndicator1.IconPadding"))));
            this.loadingIndicator1.Name = "loadingIndicator1";
            this.toolTip1.SetToolTip(this.loadingIndicator1, resources.GetString("loadingIndicator1.ToolTip"));
            // 
            // RedisBrowserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wsConnected);
            this.Controls.Add(this.wsConnect);
            this.Controls.Add(this.wsLoading);
            this.Name = "RedisBrowserForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.wsConnected.ResumeLayout(false);
            this.wsConnected.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.ImageList largeImgList;
        private System.Windows.Forms.ImageList smallImgList;
        private BrightIdeasSoftware.VirtualObjectListView olvKeys;
        private BrightIdeasSoftware.OLVColumn olvcKey;
        private BrightIdeasSoftware.OLVColumn olvcType;
        private BrightIdeasSoftware.OLVColumn olvcTTL;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
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
    }
}