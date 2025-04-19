using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace QLCH_NuocGiaiKhat.CustomBackgroud
{
    internal class GradientPanel : UserControl
    {
        private int borderRadius = 20;
        private float angle = 45;

        private Color color0 = ColorTranslator.FromHtml("#FFFFFF"); // Màu trắng
        private Color color1 = ColorTranslator.FromHtml("#4169E1"); // Xanh dương (DodgerBlue)

        private Timer timer = new Timer();

        [ToolboxItem(true)]
        public GradientPanel()
        {
            DoubleBuffered = true;
            timer.Interval = 1; // nhanh gấp đôi
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public float Angle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color Color0
        {
            get { return color0; }
            set { color0 = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, color0, color1, angle))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle = (angle + 0.5f) % 360; // xoay chậm hơn cho đẹp
            Invalidate();
        }
    }
}
