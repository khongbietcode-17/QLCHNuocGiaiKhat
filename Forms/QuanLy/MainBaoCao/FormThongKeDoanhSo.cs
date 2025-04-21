using QLCH_NuocGiaiKhat.Forms.QuanLy.MainBaoCao;
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
        private FormBaoCaoTonKho baocaotonkho;
        public FormThongKeDoanhSo()
        {
            InitializeComponent();
            baocaotonkho = new FormBaoCaoTonKho(); // <-- Thêm dòng này
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
       
            // Tạo instance của form
            

            //Chuyển Form thành kiểu "nhúng" vào panel
            baocaotonkho.TopLevel = false;
            baocaotonkho.FormBorderStyle = FormBorderStyle.None;
            baocaotonkho.Dock = DockStyle.Fill;

            // Thêm vào panel1
            panel1.Controls.Clear(); // Xóa form trước đó (nếu cần)
            panel1.Controls.Add(baocaotonkho);
            baocaotonkho.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKeDoanhSo_Load(object sender, EventArgs e)
        {


            // Chuyển Form thành kiểu "nhúng" vào panel
           baocaotonkho.TopLevel = false;
           baocaotonkho.FormBorderStyle = FormBorderStyle.None;
           baocaotonkho.Dock = DockStyle.Fill;

            //Thêm vào panel1
            panel1.Controls.Clear(); // Xóa form trước đó (nếu cần)
           panel1.Controls.Add(baocaotonkho);
           baocaotonkho.Show();

        }
    }
}
