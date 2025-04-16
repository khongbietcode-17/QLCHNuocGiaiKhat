using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormND_ThemThongTin : Form
    {
        private int idNguoiDung; // biến lưu ID người dùng nhận từ bước trước
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        FormThemNhanVien _parent;


        public FormND_ThemThongTin(FormThemNhanVien parent, int id) // constructor nhận ID
        {
            InitializeComponent();
            idNguoiDung = id;
            _parent = parent;
        }

        private void FormND_ThemThongTin_Load(object sender, EventArgs e)
        {
            // Có thể load dữ liệu gì đó nếu cần
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHoanThanh_Click_1(object sender, EventArgs e)
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
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối SQL Server: " + ex.Message);
                    return;
                }


                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ThongTinNguoiDung (IDNguoiDung, Hoten, Email, Sodienthoai, Diachi) " +
                    "VALUES (@id, @ht, @em, @sdt, @dc)", conn);

                cmd.Parameters.AddWithValue("@id", idNguoiDung);
                cmd.Parameters.AddWithValue("@ht", hoTen);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@dc", diaChi);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Đăng ký thành công!");
            _parent.Close(); // hoặc Reset form nếu cần
        }
    }
}
