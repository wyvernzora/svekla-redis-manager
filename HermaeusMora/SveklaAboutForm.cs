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
    public partial class SveklaAboutForm : Form
    {
        public SveklaAboutForm()
        {
            InitializeComponent();
        }

        private void SveklaAboutForm_Load(object sender, EventArgs e)
        {
            sveklaPulsar1.Animation = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sveklaPulsar1.Animation = !checkBox1.Checked;
        }

        private void sveklaPulsar1_Click(object sender, EventArgs e)
        {

        }
    }
}
