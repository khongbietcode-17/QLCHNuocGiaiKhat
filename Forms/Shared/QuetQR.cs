using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using ZXing;

namespace QLCH_NuocGiaiKhat.Forms.Shared
{
    public partial class QuetQR : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;

        public QuetQR()
        {
            InitializeComponent();
            this.FormClosing += QuetQR_FormClosing;
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
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Crop ảnh thành hình vuông
                int size = Math.Min(bitmap.Width, bitmap.Height);
                int x = (bitmap.Width - size) / 2;
                int y = (bitmap.Height - size) / 2;
                Rectangle cropArea = new Rectangle(x, y, size, size);
                Bitmap squareImage = bitmap.Clone(cropArea, bitmap.PixelFormat);
                bitmap.Dispose();

                // Cập nhật ảnh trên UI an toàn từ thread khác
                if (picCam.InvokeRequired)
                {
                    picCam.Invoke(new Action(() =>
                    {
                        if (picCam.Image != null) picCam.Image.Dispose();
                        picCam.Image = squareImage;
                    }));
                }
                else
                {
                    if (picCam.Image != null) picCam.Image.Dispose();
                    picCam.Image = squareImage;
                }
            }
            catch (Exception ex)
            {
                // Có thể log nếu cần
            }
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
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picCam.Image != null)
            {
                try
                {
                    Bitmap imgForScan = (Bitmap)picCam.Image.Clone();
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(imgForScan);
                    imgForScan.Dispose();

                    if (result != null)
                    {
                        timer1.Stop();

                        if (cam != null && cam.IsRunning)
                        {
                            cam.SignalToStop();
                            cam.WaitForStop();
                        }

                        this.Tag = result.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Log nếu cần
                }
            }
        }

        private void QuetQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();

            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.SignalToStop();
                    cam.WaitForStop();
                }

                cam.NewFrame -= Cam_NewFrame;
                cam = null;
            }

            if (picCam.Image != null)
            {
                picCam.Image.Dispose();
                picCam.Image = null;
            }
        }
    }
}
