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
            panel2.Visible = false;
        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text;
            string matkhau = txtMatkhau.Text;
            string vaitro = cboVaitro.Text;
            
            if (taikhoan == "" || matkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();

                // Kiểm tra trùng tài khoản
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NguoiDung WHERE Taikhoan = @tk", conn);
                checkCmd.Parameters.AddWithValue("@tk", taikhoan);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.");
                    return;
                }

                // Thêm tài khoản vào bảng NguoiDung
                SqlCommand insertCmd = new SqlCommand("INSERT INTO NguoiDung (Taikhoan, Matkhau, Vaitro) OUTPUT INSERTED.ID VALUES (@tk,@mk,@vt)", conn);
                insertCmd.Parameters.AddWithValue("@tk", taikhoan);
                insertCmd.Parameters.AddWithValue("@mk", matkhau);
                insertCmd.Parameters.AddWithValue("@vt", vaitro);

                idNguoiDungTam = (int)insertCmd.ExecuteScalar();

            }
            // Chuyển sang bước 2
            panel1.Visible = false;
            panel2.Visible = true;
            
        }
   
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            if (hoTen == "" || email == "" || sdt == "" || diaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO ThongTinNguoiDung (IDNguoiDung, Hoten, Email, Sodienthoai, Diachi) " +
                                                "VALUES (@id, @ht, @em, @sdt, @dc)", conn);
                cmd.Parameters.AddWithValue("@id", idNguoiDungTam);
                cmd.Parameters.AddWithValue("@ht", hoTen);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@dc", diaChi);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Đăng ký thành công!");
            this.Close(); // hoặc Reset form nếu muốn
        
        }
    }
}
