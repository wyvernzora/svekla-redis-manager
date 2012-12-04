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
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_program,
            this.mms_help});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // mms_program
            // 
            this.mms_program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToNewServerToolStripMenuItem});
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
            this.mms_help.Name = "mms_help";
            resources.ApplyResources(this.mms_help, "mms_help");
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
    }
}

