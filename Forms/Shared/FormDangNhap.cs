using QLCH_NuocGiaiKhat.Forms.NhanVien;
using QLCH_NuocGiaiKhat.Forms.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLCH_NuocGiaiKhat.Forms.Shared
{
    public partial class FormDangNhap: Form
    {
        string chuoiketnoi= "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = "SELECT Vaitro FROM Nguoidung WHERE Taikhoan = @tk AND Matkhau = @mk";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tk", taikhoan);
                cmd.Parameters.AddWithValue("@mk", matkhau);

                conn.Open();
                object vaitro = cmd.ExecuteScalar();
                conn.Close();

                if(vaitro != null)
                {
                    string vt = vaitro.ToString();
                    if(vt == "QuanLy")
                    {
                        FormMain_QuanLy formQL = new FormMain_QuanLy(taikhoan);
                        this.Hide();
                        formQL.ShowDialog();
                        this.Show();
                    }
                    else if(vt == "NhanVien")
                    {
                        FormMain_NhanVien formNV = new FormMain_NhanVien(taikhoan);
                        this.Hide();
                        formNV.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                    lblThongBao.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
