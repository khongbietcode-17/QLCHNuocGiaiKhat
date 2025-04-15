using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormND_ThemTaiKhoan: Form
    {
        int idNguoiDungTam; // dùng để lưu ID sau khi thêm bước 1
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        FormThemNhanVien parentForm;

        public FormND_ThemTaiKhoan(FormThemNhanVien parent)
        {
            InitializeComponent();
            parentForm = parent;
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
                
                parentForm.ShowFormThongTin(idNguoiDungTam);
            }  
        }

        private void FormND_ThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
