using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Svekla.UI.Components;

namespace Svekla.UI.Controls
{
    public partial class SveklaPulsar : Control
    {
        #region Win32 API

        private const int WM_PAINT = 0x000F;
        private const int WM_ERASEBKGND = 0x0014;
        private const int WM_PRINTCLIENT = 0x0318;

        // Win32 Structures
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public int fErase;
            public RECT rcPaint;
            public int fRestore;
            public int fIncUpdate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        // Win32 Functions
        [DllImport("user32.dll")]
        private static extern IntPtr BeginPaint(IntPtr hWnd,
                                        ref PAINTSTRUCT paintStruct);

        [DllImport("user32.dll")]
        private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT paintStruct);

        #endregion

        const int SIZE = 400;
        const int CELL_W = 312;
        const int CELL_H = 159;
        const int FPS = 60;
        const int RAIN_MARGIN = 30;
        const double B_SPEED_X = -2;
        const double B_SPEED_Y = -1;
        const double DECAY = 0.06; // n% decay in pulse per frame
        const double INIT_PULSE = 1.0f;
        const double TGT_PULSE = 1.1f;
        readonly int[] CELL_X = { 44, 44, 44 };
        readonly int[] CELL_Y = { 71, 122, 170 };
        private readonly Bitmap BODY_CELL = Properties.Resources.svekla_cell_o;
        private readonly Bitmap LOGO_CELL = Properties.Resources.svekla_cell_h;
        private readonly Bitmap FOPS_LOGO = Properties.Resources.svekla_foundops_wm;
        

        private double[] cellPulse = new Double[] { INIT_PULSE, INIT_PULSE, INIT_PULSE};
        private int[] cellPulseCount = new int[] { 0, 15, 30 };
        private double bOffsetX = 0;
        private double bOffsetY = 0;
        private Timer t;
        private Int32 fc = 0;
        private Boolean dragging = false;
        private Random rand = new Random();

        RippleEffect effect;
        Bitmap frame;

        // Snow Prevention
        

        public SveklaPulsar()
        {
            InitializeComponent();
            frame = new Bitmap(SIZE, SIZE);

            t = new Timer();
            t.Interval = (int)(1000 / FPS);
            t.Tick += (Object o, EventArgs e) =>
                {
                    UpdateFrame();
                };

            effect = new RippleEffect(SIZE, SIZE);

            this.MouseDown += (Object o, MouseEventArgs e) =>
            {
                Splash(e.Location.X, e.Location.Y, ClickSplashRadius);
                dragging = true;
            };
            this.MouseUp += (Object o, MouseEventArgs e) =>
            { dragging = false; };
            this.MouseMove += (Object o, MouseEventArgs e) =>
            {
                if (dragging)
                {
                    Point lc = Translate(e.Location);
                    Splash(e.Location.X, e.Location.Y, DragSplashRadius);
                }
            };
            
            ClickSplashRadius = 20;
            DragSplashRadius = 10;
        }

        public Boolean Animation
        {
            get { return t.Enabled; }
            set { t.Enabled = value; }
        }

        public Boolean Raindrops
        { get; set; }

        public RippleEffect RippleEffect
        { get { return effect; } }

        public Int32 ClickSplashRadius
        { get; set; }

        public Int32 DragSplashRadius
        { get; set; }

        public void Pulse(Int32 index, Double magnitude)
        {
            cellPulse[index] = magnitude;
        }

        public void Pulse(Int32 index)
        {
            Pulse(index, TGT_PULSE);
        }

        public void Splash(Int32 x, Int32 y, Int32 radius)
        {
            Point lc = new Point(x, y);
            lc = Translate(lc);
            effect.Splash(lc.X, lc.Y, radius);
        }

        #region Rendering Frame

        private void UpdateFrame()
        {
            fc++;

            // update b offsets
            bOffsetX += B_SPEED_X;
            bOffsetY += B_SPEED_Y;

            if (Math.Abs(bOffsetY) > FOPS_LOGO.Height)
                bOffsetY = 0;
            if (Math.Abs(bOffsetX) > FOPS_LOGO.Width)
                bOffsetX = 0;

            // raindrops
            if (Raindrops)
            {
                if (rand.Next(100) <= 3)
                {
                    int x = rand.Next(RAIN_MARGIN, SIZE - RAIN_MARGIN);
                    int y = rand.Next(RAIN_MARGIN, SIZE - RAIN_MARGIN);
                    int r = rand.Next(5, 10);
                    effect.Splash(x, y, r);
                }

            }

            // update
            for (int i = 0; i < 3; i++)
            {
                // Pulse
                if (++cellPulseCount[i] == 60)
                {
                    cellPulse[i] = TGT_PULSE;
                    cellPulseCount[i] = 0;
                }

                // Apply Decay
                double dltDecay = (cellPulse[i] - INIT_PULSE) * DECAY;
                if (dltDecay < 0.003)
                    dltDecay = 0.003;
                if (cellPulse[i] != INIT_PULSE)
                {
                    cellPulse[i] -= dltDecay;
                    if (cellPulse[i] < INIT_PULSE)
                        cellPulse[i] = INIT_PULSE;
                }
            }

            

            effect.Update();
            this.Invalidate();
        }

        private Bitmap RenderRawFrame()
        {
            
            Graphics fg = Graphics.FromImage(frame);

            fg.Clear(this.BackColor);

            // render background
            int bgw = FOPS_LOGO.Width;
            int bgh = FOPS_LOGO.Height;

            int ox = (int)Math.Round(bOffsetX);
            int oy = (int)Math.Round(bOffsetY);

            
            for (int i = ox - bgw; i <= frame.Width; i += 280)
            {
                for (int j = oy - bgh; j <= frame.Height; j += 154)
                {
                    fg.DrawImage(FOPS_LOGO, new Rectangle(i, j, 280, 154));
                }

            }
            
                // render pulsing Svekla logo
            for (int i = 2; i >= 0; i--)
            {
                int rcx = CELL_X[i];
                int rcy = CELL_Y[i];
                int cw = (int)(CELL_W * cellPulse[i]);
                int ch = (int)(CELL_H * cellPulse[i]);

                rcx -= (cw - CELL_W) / 2;
                rcy -= (ch - CELL_H) / 2;

                if (i != 0)
                    fg.DrawImage(BODY_CELL, new Rectangle(rcx, rcy, cw, ch));
                else
                    fg.DrawImage(LOGO_CELL, new Rectangle(rcx, rcy, cw, ch));
            }

            int lw = frame.Width - 1;
            int lh = frame.Height - 1;
            Pen border = new Pen(new SolidBrush(Color.Black), 1);
            fg.DrawLine(border, new Point(0, 0), new Point(0, lh));
            fg.DrawLine(border, new Point(0, 0), new Point(lw, 0));
            fg.DrawLine(border, new Point(lw, 0), new Point(lh, lw));
            fg.DrawLine(border, new Point(0, lh), new Point(lh, lw));


            return frame;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_ERASEBKGND:
                    return;
                case WM_PAINT:
                    PAINTSTRUCT paintStruct = new PAINTSTRUCT();
                    IntPtr screenHdc = BeginPaint(m.HWnd, ref paintStruct);

                    Bitmap f = RenderRawFrame();
                    f = effect.Render(f);

                    using (Graphics screen = Graphics.FromHdc(screenHdc))
                    {
                        screen.DrawImage(f, this.ClientRectangle);
                    }
                    EndPaint(m.HWnd, ref paintStruct);
                    return;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        #endregion

        #region Utility Methods

        private Point Translate(Point p)
        {
            double cx = (double)SIZE / (double)this.Width;
            double cy = (double)SIZE / (double)this.Height;
            return new Point((int)(p.X * cx), (int)(p.Y * cy));
        }

        #endregion

        #region Designer Generated Code

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        #endregion
    }
}
