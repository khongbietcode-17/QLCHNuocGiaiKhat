using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;


namespace QLCH_NuocGiaiKhat.Forms.Shared
{


    public partial class QuetQR: Form
    {

        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public QuetQR()
        {
            InitializeComponent();
        }

        private void QuetQR_Load(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in cameras)
            {
                cboCam.Items.Add(camera.Name);
            }

            if (cboCam.Items.Count > 0)
                cboCam.SelectedIndex = 0;

            timer1.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            picCam.Image = bitmap;
           

            // Crop ảnh thành hình vuông (lấy vùng giữa)
            int size = Math.Min(bitmap.Width, bitmap.Height);
            int x = (bitmap.Width - size) / 2;
            int y = (bitmap.Height - size) / 2;
            Rectangle cropArea = new Rectangle(x, y, size, size);

            Bitmap squareImage = bitmap.Clone(cropArea, bitmap.PixelFormat);

            picCam.Image = squareImage;

            // Giải phóng ảnh gốc nếu cần
            bitmap.Dispose();
        }

        private void cboCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCam(cboCam.SelectedIndex);
        }
        private void StartCam(int index)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
            }

            cam = new VideoCaptureDevice(cameras[index].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.SignalToStop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picCam.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)picCam.Image);
                if (result != null)
                {
                    string qrData = result.Text;
                    timer1.Stop();
                    cam.SignalToStop();

                    // Truyền mã QR (ID người dùng) ra ngoài
                    this.Tag = qrData;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
