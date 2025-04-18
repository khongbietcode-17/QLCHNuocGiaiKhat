using QLCH_NuocGiaiKhat.CustomBackgroud;
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
        private bool matKhauDangAn = true;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            GradientPanel panelChinh = new GradientPanel();
            panelChinh.Dock = DockStyle.Fill; // Dock vào toàn bộ form
            this.Controls.Add(panelChinh);
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = @"
SELECT Nguoidung.Vaitro, ThongTinNguoiDung.HoTen 
FROM Nguoidung
INNER JOIN ThongTinNguoiDung ON Nguoidung.Id = ThongTinNguoiDung.IdNguoiDung 
WHERE Nguoidung.Taikhoan = @tk AND Nguoidung.Matkhau = @mk";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tk", taikhoan);
                cmd.Parameters.AddWithValue("@mk", matkhau);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string vaitro = reader["Vaitro"].ToString();
                    string hoten = reader["HoTen"].ToString();

                    if (vaitro == "QuanLy")
                    {
                        FormMain_QuanLy formQL = new FormMain_QuanLy(hoten);
                        this.Hide();
                        formQL.ShowDialog();
                        this.Show();
                    }
                    else if (vaitro == "NhanVien")
                    {
                        FormMain_NhanVien formNV = new FormMain_NhanVien(hoten);
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
                reader.Close();
                conn.Close();
            }
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            matKhauDangAn = !matKhauDangAn;

            txtMatKhau.UseSystemPasswordChar = matKhauDangAn;

            // Đổi hình icon nếu bạn có thêm ảnh mắt mở và mắt đóng
            picEye.Image = matKhauDangAn
               ? Properties.Resources.eye // mắt đang ẩn
               : Properties.Resources.hidden; // mắt đang hiện
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
