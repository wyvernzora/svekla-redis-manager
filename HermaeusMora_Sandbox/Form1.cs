using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceStack.Redis;

namespace HermaeusMora_Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedisClient cli = new RedisClient("192.168.2.31");
            Random r = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                cli.Add(r.Next().ToString(), r.Next().ToString());
            }
            cli.Save();
        }
    }
}
