using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.CustomBackgroud
{
    public class CirclePictureBox : PictureBox
    {
        private int borderSize = 5;
        private Color borderColor = Color.White;

        [Category("Custom")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public CirclePictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = Math.Min(this.Width, this.Height);
            Rectangle rect = new Rectangle(borderSize / 2, borderSize / 2, diameter - borderSize, diameter - borderSize);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path); // Cắt hình control thành hình tròn

                // Vẽ ảnh
                if (this.Image != null)
                    g.DrawImage(this.Image, rect);

                // Vẽ viền
                using (Pen borderPen = new Pen(borderColor, borderSize))
                {
                    g.DrawEllipse(borderPen, rect);
                }
            }
        }
    }
}
