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
            this.connectToNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitSveklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_data = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSveklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_view = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.connectToNewServerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.backgroundSaveToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.deleteDatabaseToolStripMenuItem,
            this.deleteAllDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitSveklaToolStripMenuItem});
            this.mms_program.Name = "mms_program";
            resources.ApplyResources(this.mms_program, "mms_program");
            // 
            // connectToNewServerToolStripMenuItem
            // 
            this.connectToNewServerToolStripMenuItem.Name = "connectToNewServerToolStripMenuItem";
            resources.ApplyResources(this.connectToNewServerToolStripMenuItem, "connectToNewServerToolStripMenuItem");
            this.connectToNewServerToolStripMenuItem.Click += new System.EventHandler(this.connectToNewServerToolStripMenuItem_Click);
            // 
            // mms_help
            // 
            this.mms_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSveklaToolStripMenuItem});
            this.mms_help.Name = "mms_help";
            resources.ApplyResources(this.mms_help, "mms_help");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // exitSveklaToolStripMenuItem
            // 
            this.exitSveklaToolStripMenuItem.Name = "exitSveklaToolStripMenuItem";
            resources.ApplyResources(this.exitSveklaToolStripMenuItem, "exitSveklaToolStripMenuItem");
            // 
            // mms_data
            // 
            this.mms_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripSeparator1,
            this.toolStripMenuItem8});
            this.mms_data.Name = "mms_data";
            resources.ApplyResources(this.mms_data, "mms_data");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Svekla.Properties.Resources.Save16;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // backgroundSaveToolStripMenuItem
            // 
            this.backgroundSaveToolStripMenuItem.Image = global::Svekla.Properties.Resources.Save16;
            this.backgroundSaveToolStripMenuItem.Name = "backgroundSaveToolStripMenuItem";
            resources.ApplyResources(this.backgroundSaveToolStripMenuItem, "backgroundSaveToolStripMenuItem");
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Image = global::Svekla.Properties.Resources.Shutdown16;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            resources.ApplyResources(this.shutdownToolStripMenuItem, "shutdownToolStripMenuItem");
            // 
            // deleteDatabaseToolStripMenuItem
            // 
            this.deleteDatabaseToolStripMenuItem.Image = global::Svekla.Properties.Resources.Warning16;
            this.deleteDatabaseToolStripMenuItem.Name = "deleteDatabaseToolStripMenuItem";
            resources.ApplyResources(this.deleteDatabaseToolStripMenuItem, "deleteDatabaseToolStripMenuItem");
            // 
            // deleteAllDataToolStripMenuItem
            // 
            this.deleteAllDataToolStripMenuItem.Image = global::Svekla.Properties.Resources.Warning16;
            this.deleteAllDataToolStripMenuItem.Name = "deleteAllDataToolStripMenuItem";
            resources.ApplyResources(this.deleteAllDataToolStripMenuItem, "deleteAllDataToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Svekla.Properties.Resources.RedisString16;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Svekla.Properties.Resources.RedisList16;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Svekla.Properties.Resources.RedisSet16;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Svekla.Properties.Resources.RedisSortedSet16;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Svekla.Properties.Resources.RedisHash16;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // aboutSveklaToolStripMenuItem
            // 
            this.aboutSveklaToolStripMenuItem.Image = global::Svekla.Properties.Resources.Info16;
            this.aboutSveklaToolStripMenuItem.Name = "aboutSveklaToolStripMenuItem";
            resources.ApplyResources(this.aboutSveklaToolStripMenuItem, "aboutSveklaToolStripMenuItem");
            // 
            // mms_view
            // 
            this.mms_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.mms_view.Name = "mms_view";
            resources.ApplyResources(this.mms_view, "mms_view");
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::Svekla.Properties.Resources.LargeIcons;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = global::Svekla.Properties.Resources.View16;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = global::Svekla.Properties.Resources.RedisList16;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::Svekla.Properties.Resources.Details16;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
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
        private System.Windows.Forms.ToolStripMenuItem connectToNewServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mms_help;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitSveklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mms_data;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem aboutSveklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mms_view;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
    }
}

