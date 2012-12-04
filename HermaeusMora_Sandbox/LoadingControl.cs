using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HermaeusMora_Sandbox
{
    public partial class LoadingControl : Control
    {
        Image frames;
        Int32 cFi = 0;
        Timer timer;
        Rectangle[] frameData = new Rectangle[]
        {
            new Rectangle(0, 0, 256, 256),
            new Rectangle(256, 0, 256, 256),
            new Rectangle(0, 256, 256, 256),
            new Rectangle(256, 256, 256, 256)
        };

        public LoadingControl()
        {
            InitializeComponent();

            frames = Properties.Resources.LoadingAnimation;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (Object o, EventArgs e) =>
                {
                    this.Refresh();
                    cFi++;
                    if (cFi >= frameData.Length)
                        cFi = 0;
                };
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawImage(frames, new Rectangle(0, 0, 256, 256), frameData[cFi], GraphicsUnit.Pixel);
            base.OnPaint(pe);
        }

        public new Boolean Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                timer.Enabled = value;
                if (!value) cFi = 0;
            }
        }
    }
}
