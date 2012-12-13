namespace Svekla
{
    partial class SveklaAboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SveklaAboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sveklaPulsar1 = new Svekla.UI.Controls.SveklaPulsar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Svekla Redis Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "2012 (C) Jieni Luchijinzhou and contributors";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(423, 393);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Disable Animation";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(418, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 312);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // sveklaPulsar1
            // 
            this.sveklaPulsar1.Animation = false;
            this.sveklaPulsar1.ClickSplashRadius = 20;
            this.sveklaPulsar1.DragSplashRadius = 10;
            this.sveklaPulsar1.Location = new System.Drawing.Point(12, 13);
            this.sveklaPulsar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sveklaPulsar1.Name = "sveklaPulsar1";
            this.sveklaPulsar1.Raindrops = false;
            this.sveklaPulsar1.Size = new System.Drawing.Size(400, 400);
            this.sveklaPulsar1.TabIndex = 0;
            this.sveklaPulsar1.Text = "sveklaPulsar1";
            this.sveklaPulsar1.Click += new System.EventHandler(this.sveklaPulsar1_Click);
            // 
            // SveklaAboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sveklaPulsar1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SveklaAboutForm";
            this.ShowInTaskbar = false;
            this.Text = "About Svekla Redis Manager...";
            this.Load += new System.EventHandler(this.SveklaAboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.SveklaPulsar sveklaPulsar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
    }
}