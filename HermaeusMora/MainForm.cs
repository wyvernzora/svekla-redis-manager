using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Svekla
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
        }

        private void connectToNewServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedisBrowserForm rbf = new RedisBrowserForm();
            rbf.MdiParent = this;
            rbf.Show();
        }
    }
}
