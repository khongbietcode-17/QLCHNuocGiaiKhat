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
    public partial class FormQLNhanVien : Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormQLNhanVien()
        {
            InitializeComponent();
        }
        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            cboVaiTroLoc.SelectedIndex = 0; // Mặc định là Tất cả
            this.ControlBox = false;
            string query = @"SELECT 
                        nd.ID, 
                        nd.Vaitro,
                        nd.Taikhoan,
                        nd.Matkhau,
                        tt.HoTen,
                        tt.Email,
                        tt.DiaChi,
                        tt.SoDienThoai
                     FROM NguoiDung nd
                     LEFT JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Chức Vụ";
            dataGridView1.Columns[2].HeaderText = "Tài khoản";
            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
            dataGridView1.Columns[4].HeaderText = "Họ và tên";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Địa chỉ";
            dataGridView1.Columns[7].HeaderText = "SĐT";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien form = new FormThemNhanVien();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
                LoadNguoiDung(); // Load lại sau khi thêm

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();            // ID
                cboVaiTro.Text = row.Cells[1].Value?.ToString();        // Vai trò
                txtTaiKhoan.Text = row.Cells[2].Value?.ToString();      // Tài khoản
                txtMatkhau.Text = row.Cells[3].Value?.ToString();       // Mật khẩu
                txtHoTen.Text = row.Cells[4].Value?.ToString();         // Họ tên
                txtEmail.Text = row.Cells[5].Value?.ToString();         // Email
                txtDiaChi.Text = row.Cells[6].Value?.ToString();        // Địa chỉ
                txtSoDienThoai.Text = row.Cells[7].Value?.ToString();   // SĐT
            }
        }
        private void LoadNguoiDung()
        {
            this.ControlBox = false;
            string query = @"SELECT 
                        nd.ID, 
                        nd.Vaitro,
                        nd.Taikhoan,
                        nd.Matkhau,
                        tt.HoTen,
                        tt.Email,
                        tt.DiaChi,
                        tt.SoDienThoai
                     FROM NguoiDung nd
                     LEFT JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Chức Vụ";
            dataGridView1.Columns[2].HeaderText = "Tài khoản";
            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
            dataGridView1.Columns[4].HeaderText = "Họ và tên";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Địa chỉ";
            dataGridView1.Columns[7].HeaderText = "SĐT";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatkhau.Text.Trim();
            string vaitro = cboVaiTro.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();

                // Cập nhật bảng NguoiDung
                string updateNguoiDung = "UPDATE NguoiDung SET Taikhoan = @tk, Matkhau = @mk, Vaitro = @vt WHERE ID = @id";
                using (SqlCommand cmd1 = new SqlCommand(updateNguoiDung, conn))
                {
                    cmd1.Parameters.AddWithValue("@tk", taikhoan);
                    cmd1.Parameters.AddWithValue("@mk", matkhau);
                    cmd1.Parameters.AddWithValue("@vt", vaitro);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();
                }

                // Cập nhật bảng ThongTinNguoiDung
                string updateThongTin = @"
                    UPDATE ThongTinNguoiDung 
                    SET HoTen = @ht, Email = @em, DiaChi = @dc, SoDienThoai = @sdt 
                    WHERE IDNguoiDung = @id";
                using (SqlCommand cmd2 = new SqlCommand(updateThongTin, conn))
                {
                    cmd2.Parameters.AddWithValue("@ht", hoten);
                    cmd2.Parameters.AddWithValue("@em", email);
                    cmd2.Parameters.AddWithValue("@dc", diachi);
                    cmd2.Parameters.AddWithValue("@sdt", sdt);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadNguoiDung(); // Load lại sau khi cập nhật
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (txtId.Text == null || txtId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string id = txtId.Text.Trim();

                using (SqlConnection conn = new SqlConnection(chuoiketnoi))
                {
                    conn.Open();

                    // Xóa thông tin trong bảng ThongTinNguoiDung trước (vì có khóa ngoại)
                    string deleteThongTin = "DELETE FROM ThongTinNguoiDung WHERE IDNguoiDung = @id";
                    using (SqlCommand cmd1 = new SqlCommand(deleteThongTin, conn))
                    {
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();
                    }

                    // Xóa trong bảng NguoiDung
                    string deleteNguoiDung = "DELETE FROM NguoiDung WHERE ID = @id";
                    using (SqlCommand cmd2 = new SqlCommand(deleteNguoiDung, conn))
                    {
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh lại danh sách
                LoadNguoiDung();

                // Xóa thông tin trong các TextBox để tránh hiểu lầm
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtId.Clear();
            txtTaiKhoan.Clear();
            txtMatkhau.Clear();
            cboVaiTro.SelectedIndex = -1;
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNguoiDung();

        }
        private void TimKiemNguoiDung()
        {
            string tuKhoa = txtTenTimKiem.Text.Trim().ToLower();
            string vaiTroLoc = cboVaiTroLoc.Text;

            string query = @"SELECT 
                        nd.ID, 
                        nd.Vaitro,
                        nd.Taikhoan,
                        nd.Matkhau,
                        tt.HoTen,
                        tt.Email,
                        tt.DiaChi,
                        tt.SoDienThoai
                    FROM NguoiDung nd
                    LEFT JOIN ThongTinNguoiDung tt ON nd.ID = tt.IDNguoiDung";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Tạo bản sao để lọc dữ liệu
                DataTable dtLoc = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    string hoTen = row["HoTen"]?.ToString() ?? "";
                    string vaiTro = row["Vaitro"]?.ToString() ?? "";

                    string hoTenKhongDau = BoDauTiengViet(hoTen);
                    string tuKhoaKhongDau = BoDauTiengViet(tuKhoa);

                    bool hopTen = string.IsNullOrEmpty(tuKhoa) || hoTenKhongDau.Contains(tuKhoaKhongDau);
                    bool hopVaiTro = (vaiTroLoc == "Tất cả") || vaiTro.Equals(vaiTroLoc, StringComparison.OrdinalIgnoreCase);

                    if (hopTen && hopVaiTro)
                    {
                        dtLoc.ImportRow(row);
                    }
                }

                dataGridView1.DataSource = dtLoc;
            }

            // Gán lại tên cột
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Chức Vụ";
            dataGridView1.Columns[2].HeaderText = "Tài khoản";
            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
            dataGridView1.Columns[4].HeaderText = "Họ và tên";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Địa chỉ";
            dataGridView1.Columns[7].HeaderText = "SĐT";
        }

        public static string BoDauTiengViet(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC).ToLower();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNguoiDung(); // Load lại sau khi cập nhật
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
