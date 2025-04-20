using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormThongKeDoanhSo: Form
    {   
        //Form_BaoCaoTonKho baocaotonkho;
        public FormThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            panelX.Location = new Point(
                btnLamMoi.Location.X,
                btnLamMoi.Location.Y + btnLamMoi.Height
                );
            panelX.Visible = true;
            panelX.BringToFront();
            panelX.Width = btnLamMoi.Width;
            // Tạo instance của form
            //baocaotonkho = new Form_BaoCaoTonKho();

            // Chuyển Form thành kiểu "nhúng" vào panel
            //baocaotonkho.TopLevel = false;
            //baocaotonkho.FormBorderStyle = FormBorderStyle.None;
            //baocaotonkho.Dock = DockStyle.Fill;

            // Thêm vào panel1
            panel1.Controls.Clear(); // Xóa form trước đó (nếu cần)
           // panel1.Controls.Add(baocaotonkho);
            //baocaotonkho.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKeDoanhSo_Load(object sender, EventArgs e)
        {
            panelX.Location = new Point(
             btnLamMoi.Location.X,
             btnLamMoi.Location.Y + btnLamMoi.Height
             );
            panelX.Visible = true;
            panelX.BringToFront();
            panelX.Width = btnLamMoi.Width;
           // baocaotonkho = new Form_BaoCaoTonKho();

            // Chuyển Form thành kiểu "nhúng" vào panel
           // baocaotonkho.TopLevel = false;
           // baocaotonkho.FormBorderStyle = FormBorderStyle.None;
          //  baocaotonkho.Dock = DockStyle.Fill;

            // Thêm vào panel1
            panel1.Controls.Clear(); // Xóa form trước đó (nếu cần)
           // panel1.Controls.Add(baocaotonkho);
           // baocaotonkho.Show();

        }
    }
}
