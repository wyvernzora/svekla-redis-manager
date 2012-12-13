using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace Svekla.UI.Components
{
    public unsafe class RippleEffect
    {
        // Texture and frame buffer
        private Bitmap texture;
        private Bitmap frame;

        // Wave buffers
        private Int32[] frontBuffer;
        private Int32[] backBuffer;


        public RippleEffect()
        {
        }

        public RippleEffect(int w, int h)
        {
            // allocate buffers
            this.frontBuffer = new Int32[w * h];
            this.backBuffer = new Int32[frontBuffer.Length];
            frame = new Bitmap(w, h);
        }

        private void Initialize()
        {
            if (texture == null)
                throw new Exception();

            // allocate buffers
            this.frontBuffer = new Int32[texture.Width * texture.Height];
            this.backBuffer = new Int32[frontBuffer.Length];

            frame = new Bitmap(texture);
        }

        #region Properties

        public Bitmap Texture
        {
            get { return texture; }
            set
            {
                texture = value;
                Initialize();
            }
        }

        public Bitmap Frame
        { get { return frame; } }

        #endregion

        #region Update/Render

        public void Update()
        {
            // accessing properties involves calling methods!
            int w = texture.Width;
            int h = texture.Height;

            // fix front buffer so that .net runtime doesn't move it
            fixed (int* pF = frontBuffer, pB = backBuffer)
            {
                // top/bottom edge pixels are excluded from the loop
                for (int i = w; i < w * h - w; i++)
                {
                    // if current pixel is a left/right edge pixel, don't process it
                    if (i % w == 1 || i % w == w - 1) continue;

                    // calculate wave height
                    pB[i] = ((
                        pF[i - 1] +
                        pF[i + 1] +
                        pF[i - w] +
                        pF[i + w])  >> 1) - pB[i];
                    pB[i] -= pB[i] >> 5;
                }
            }

            // flip buffers
            int[] tmp = frontBuffer;
            frontBuffer = backBuffer;
            backBuffer = tmp;
        }

        public Bitmap Render(Bitmap ntxt)
        {
            // apply new texture if needed
            if (ntxt != null)
            {
                this.texture = ntxt;
            }

            // avoid using properties
            int w = texture.Width;
            int h = texture.Height;

            // copy current texture
            //frame = new Bitmap(texture);
            
            // lock bitmap data
            BitmapData fdat = frame.LockBits(new Rectangle(0, 0, texture.Width, texture.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData tdat = texture.LockBits(new Rectangle(0, 0, texture.Width, texture.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            // fix front buffer
            fixed (int* buffer = frontBuffer)
            {
                // get bitmap data pointers
                byte* faddr = (byte*)fdat.Scan0;
                byte* taddr = (byte*)tdat.Scan0;

               for (int i = w; i < w * h - w; i++)
                {
                   // calculate x and y offsets
                    int xo = buffer[i - 1] - buffer[i + 1];
                    int yo = buffer[i - w] - buffer[i + w];
                   
                   // shader
                    int shade = (xo - yo) / 4;

                   // temporary variables to avoid redundant calculation
                    int pxi = i * 3;
                    int fxi = pxi + xo * 3 + yo * tdat.Stride;
                    if (fxi < 0) fxi = pxi;
                    if (fxi >= w * h * 3) fxi = pxi;

                   // get pixel from texture
                    byte r = taddr[fxi];
                    byte g = taddr[fxi + 1];
                    byte b = taddr[fxi + 2];

                   // apply ripple effect
                    r = (byte)CoerceValue(r + shade, 0, 255);
                    g = (byte)CoerceValue(g + shade, 0, 255);
                    b = (byte)CoerceValue(b + shade, 0, 255);

                   // write pixel to frame buffer
                    faddr[pxi] = r;
                    faddr[pxi + 1] = g;
                    faddr[pxi + 2] = b;
                } 

                // copy edge rows
                for (int i = 0; i < w * 3; i++)
                {
                    faddr[(w * h) * 3 - i] = taddr[(w * h) * 3 - i];
                    faddr[i] = taddr[i];
                }
            }

            // unlock bitmap data
            frame.UnlockBits(fdat);
            texture.UnlockBits(tdat);

            return frame;
        }

        #endregion

        #region Interaction

        public void Splash(int x, int y, Int32 r)
        {
            if (x < 0 || x >= texture.Width || y < 0 || y >= texture.Height) return;

            Rectangle effectRect = new Rectangle(0, 0, texture.Width, texture.Height);

            for (int iy = y - r; iy < y + r; iy++)
            {
                for (int ix = x - r; ix < x + r; ix++)
                {
                    Double d = Math.Sqrt(Math.Pow(ix - x, 2) + Math.Pow(iy - y, 2));
                    Point p = new Point(ix, iy);
                    if (d < r && effectRect.Contains(p))
                        frontBuffer[ix + iy * effectRect.Width] = (int)(255 - (768 * (1 - d / r / 2)));
                }
            }
        }

        #endregion

        #region Utility Methods

        private int CoerceValue(int raw, int lo, int hi)
        {
            if (raw <= lo) return lo;
            else if (raw >= hi) return hi;
            else return raw;
        }

        #endregion
    }
}
