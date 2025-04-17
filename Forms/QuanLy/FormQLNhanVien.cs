using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QLCH_NuocGiaiKhat.Forms.QuanLy;

using static QLCH_NuocGiaiKhat.Forms.QuanLy.FormQLSanPham;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormQLNhanVien : Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormQLNhanVien()
        {
            InitializeComponent();
        }
        //CÁC LOAD 
        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
          
            LoadDanhSachNguoiDung();
            LoadNguoiDungCard();


            flowNV.AutoScroll = true; // ✅ phải có dòng này
            ScrollBarHider.HideVerticalScrollBar(flowNV); // ẩn thanh cuộn
            flowNV.Scroll += (s, ev) =>
            {
                ScrollBarHider.HideVerticalScrollBar(flowNV);
            };
            flowNV.Layout += (s, ev) =>
            {
                ScrollBarHider.HideVerticalScrollBar(flowNV);
            };

        }
        private void LoadDanhSachNguoiDung()
        {
            string query = "SELECT \r\n   nd.ID,\r\n    nd.Taikhoan,\r\n    nd.Matkhau,\r\n    nd.Vaitro,\r\n    tt.HoTen,\r\n    tt.Email,\r\n    tt.SoDienThoai,\r\n    tt.DiaChi,\r\n    tt.Anh\r\nFROM NguoiDung nd\r\nINNER JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung";
        }
        private void LoadNguoiDungCard(string keyword = "")
        {
            flowNV.Controls.Clear();
            string query = @"
    SELECT 
        nd.ID,
        nd.Taikhoan,
        nd.Matkhau,
        nd.Vaitro,
        tt.HoTen,
        tt.Email,
        tt.SoDienThoai,
        tt.DiaChi,
        tt.Anh
    FROM NguoiDung nd
    INNER JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung
    WHERE 
        tt.HoTen COLLATE Latin1_General_CI_AI LIKE @keyword
        OR nd.Taikhoan COLLATE Latin1_General_CI_AI LIKE @keyword
        OR tt.Email COLLATE Latin1_General_CI_AI LIKE @keyword
";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    ucNguoiDung ndCard = new ucNguoiDung();

                    // Gán dữ liệu từ SQL vào control của UserControl
                    ndCard.lblID.Text = "Mã ID: "+reader["ID"].ToString();
                    ndCard.lblTK.Text = "Tài khoản: " + reader["Taikhoan"].ToString();
                    ndCard.lblHoTen.Text = "" + reader["HoTen"].ToString();
                    ndCard.lblDiaChi.Text = "Địa chỉ: " + reader["DiaChi"].ToString();
                    ndCard.lblSDT.Text = "Số điện thoại: " + reader["SoDienThoai"].ToString();
                    ndCard.lblEmail.Text = "Email: " + reader["Email"].ToString();
                    ndCard.lblVaiTro.Text = "Chức vụ: " + reader["Vaitro"].ToString();

                    ndCard.Tag = reader["ID"].ToString();
                    // Xử lý hình ảnh
                    if (reader["Anh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["Anh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            ndCard.picND.Image = Image.FromStream(ms);
                        }
                    }


                    ndCard.Click += NdCard_Click;
                    // Thêm thẻ vào FlowLayoutPanel
                    flowNV.Controls.Add(ndCard);
                }
            }
        }
        //Không cần quan tâm code này ( Ẩn thanh cuộn nhưng bị lỗi rồi :) ) 
        public class ScrollBarHider
        {
            [DllImport("user32.dll")]
            private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

            private const int SB_HORZ = 0;
            private const int SB_VERT = 1;

            public static void HideVerticalScrollBar(Control control)
            {
                ShowScrollBar(control.Handle, SB_VERT, 0);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien form = new FormThemNhanVien();
            form.ShowDialog();
        }
        private void NdCard_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string ID = "";
            if(control is ucNguoiDung)
                ID = control.Tag?.ToString();
            else
                ID = control.Parent?.Tag?.ToString();

            if (ID == null || ID == "")
                return;
            string query = @"
    SELECT 
    nd.ID,
    nd.Taikhoan,
    nd.Matkhau,
    nd.Vaitro,
    tt.HoTen,
    tt.Email,
    tt.SoDienThoai,
    tt.DiaChi,
    tt.Anh
FROM NguoiDung nd
INNER JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung
WHERE nd.ID = @ID";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   txtId.Text = reader["ID"].ToString();
                   txtTaiKhoan.Text = reader["TaiKhoan"].ToString();
                   txtMatkhau.Text = reader["Matkhau"].ToString();
                   txtHoTen.Text = reader["HoTen"].ToString();
                   txtDiaChi.Text = reader["DiaChi"].ToString();
                   txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                   txtEmail.Text = reader["Email"].ToString();
                   cboVaiTro.Text = reader["Vaitro"].ToString();
                    if (reader["Anh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["Anh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            picAnhSua.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picAnhSua.Image = null;
                    }
                }
                reader.Close();
            }
        }
        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
            int id = Convert.ToInt32(txtId.Text.Trim()); // chuyển về int để chắc chắn đúng kiểu
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string ht = txtHoTen.Text.Trim();
            string em = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string cv = cboVaiTro.Text.Trim();

            byte[] Anh = null;
            if (picAnhSua.Image != null)
            {
                Anh = ImageToByteArray(picAnhSua.Image);
            }

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Cập nhật bảng NguoiDung
                    string query1 = @"UPDATE NguoiDung 
                              SET TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, VaiTro = @VaiTro
                              WHERE ID = @ID";
                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);
                    cmd1.Parameters.AddWithValue("@ID", id);
                    cmd1.Parameters.AddWithValue("@TaiKhoan", tk);
                    cmd1.Parameters.AddWithValue("@MatKhau", mk);
                    cmd1.Parameters.AddWithValue("@VaiTro", cv);
                    cmd1.ExecuteNonQuery(); // không cần lấy lại ID

                    // Cập nhật bảng ThongTinNguoiDung
                    string query2 = @"UPDATE ThongTinNguoiDung 
                              SET HoTen = @HoTen, Email = @Email, SoDienThoai = @SDT, 
                                  DiaChi = @DiaChi, Anh = @Anh
                              WHERE IDNguoiDung = @ID";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                    cmd2.Parameters.AddWithValue("@ID", id);
                    cmd2.Parameters.AddWithValue("@HoTen", ht);
                    cmd2.Parameters.AddWithValue("@Email", em);
                    cmd2.Parameters.AddWithValue("@SDT", sdt);
                    cmd2.Parameters.AddWithValue("@DiaChi", dc);
                    cmd2.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = (object)Anh ?? DBNull.Value;

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadDanhSachNguoiDung();
                    LoadNguoiDungCard();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
            int id;
            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("ID không hợp lệ. Vui lòng chọn một người dùng từ danh sách!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Xóa trong bảng ThongTinNguoiDung trước (bảng phụ phụ thuộc vào IDNguoiDung)
                    string query1 = "DELETE FROM ThongTinNguoiDung WHERE IDNguoiDung = @ID";
                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);
                    cmd1.Parameters.AddWithValue("@ID", id);
                    cmd1.ExecuteNonQuery();

                    // Sau đó xóa trong bảng NguoiDung
                    string query2 = "DELETE FROM NguoiDung WHERE ID = @ID";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                    cmd2.Parameters.AddWithValue("@ID", id);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Xóa người dùng thành công!");

                    // Làm mới danh sách
                    LoadDanhSachNguoiDung();
                    LoadNguoiDungCard();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
 
     
        private void txtTenTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTenTimKiem.Text.Trim();
            LoadNguoiDungCard(keyword); // gọi lại Load với từ khóa tìm kiếm

        }
        public static string RemoveDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
        private void cboVaiTroLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhSua.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
