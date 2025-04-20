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
using QLCH_NuocGiaiKhat.CustomBackgroud;


namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormChupAnh: Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
    
        public Image AnhDaChup { get; private set; }
        public FormChupAnh()
        {
            InitializeComponent();
            cboCam.SelectedIndexChanged += cboCam_SelectedIndexChanged; // ← THÊM Ở ĐÂY
        }

        private void FormChupAnh_Load(object sender, EventArgs e)
        {
            picCam.Width = 300; // hoặc 400, tùy kích thước bạn muốn
            picCam.Height = picCam.Width;
            picCam.SizeMode = PictureBoxSizeMode.Zoom;

            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (cameras.Count > 0)
            {
                foreach (FilterInfo camera in cameras)
                {
                    cboCam.Items.Add(camera.Name);
                }
              
                cboCam.SelectedIndex = 0; // Chọn mặc định
                StartCam(cboCam.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thiết bị camera.");
                this.Close();
            }
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
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap original = (Bitmap)eventArgs.Frame.Clone();

            // Crop ảnh thành hình vuông (lấy vùng giữa)
            int size = Math.Min(original.Width, original.Height);
            int x = (original.Width - size) / 2;
            int y = (original.Height - size) / 2;
            Rectangle cropArea = new Rectangle(x, y, size, size);

            Bitmap squareImage = original.Clone(cropArea, original.PixelFormat);

            picCam.Image = squareImage;

            // Giải phóng ảnh gốc nếu cần
            original.Dispose();
        }

  



        private void FormChupAnh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChup_Click_1(object sender, EventArgs e)
        {
            if (picCam.Image != null)
            {
                AnhDaChup = (Image)picCam.Image.Clone(); // Lưu ảnh
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cboCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCam.SelectedIndex >= 0)
            {
                StartCam(cboCam.SelectedIndex);
            }
        }

    }
}
