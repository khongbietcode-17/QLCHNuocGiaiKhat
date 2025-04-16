using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
  
    public partial class FormThemNhanVien: Form
    {
        int idNguoiDungTam; // dùng để lưu ID sau khi thêm bước 1
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormThemNhanVien()
        {
            InitializeComponent();
            
         
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            FormND_ThemTaiKhoan frmTaiKhoan = new FormND_ThemTaiKhoan(this);
            frmTaiKhoan.TopLevel = false;
            frmTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            frmTaiKhoan.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
        }
        public void ShowFormThongTin(int idNguoiDung)
        {
            FormND_ThemThongTin frmThongTin = new FormND_ThemThongTin(this, idNguoiDung);
            frmThongTin.TopLevel = false;
            frmThongTin.FormBorderStyle = FormBorderStyle.None;
            frmThongTin.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frmThongTin);
            frmThongTin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
