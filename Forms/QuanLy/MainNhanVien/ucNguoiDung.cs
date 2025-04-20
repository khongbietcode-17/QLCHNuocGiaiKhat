using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class ucNguoiDung: UserControl
    {
        public ucNguoiDung()
        {
            InitializeComponent();
        }

        private void picND_Click(object sender, EventArgs e)
        {

        }

        private void picND_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = Math.Min(picND.Width, picND.Height);
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);

            // Bo tròn ảnh bằng clip hình tròn
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                g.SetClip(path);

                // Vẽ ảnh
                if (picND.Image != null)
                {
                    g.DrawImage(picND.Image, rect);
                }

                // Vẽ viền trắng sau khi vẽ ảnh
                using (Pen borderPen = new Pen(Color.White, 5)) // độ dày viền
                {
                    g.ResetClip(); // Xoá clip để viền không bị cắt
                    g.DrawEllipse(borderPen, rect);
                }
            }
        }

        private void ucNguoiDung_Load(object sender, EventArgs e)
        {

        }
    }
}
