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
    public partial class FormQLNhaCungCap : Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormQLNhaCungCap_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM NhaCungCap";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "Mã NCC";
            dataGridView1.Columns[1].HeaderText = "Tên NCC";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Ghi Chú";
        }


        private void LoadNhaCungCap()
        {
            string query = @"SELECT * FROM NhaCungCap";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "Mã NCC";
            dataGridView1.Columns[1].HeaderText = "Tên NCC";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Ghi Chú";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }




        private void ClearForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           string maNCC = txtMaNCC.Text.Trim();
string tenNCC = txtTenNCC.Text.Trim();
string diaChi = txtDiaChi.Text.Trim();
string soDienThoai = txtSoDienThoai.Text.Trim();
string email = txtEmail.Text.Trim();
string ghiChu = txtGhiChu.Text.Trim();

if (string.IsNullOrEmpty(maNCC))
{
    MessageBox.Show("Vui lòng chọn một nhà cung cấp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
}

string query = @"
    UPDATE NhaCungCap 
    SET TenNhaCungCap = @TenNhaCungCap, 
        DiaChi = @DiaChi, 
        SoDienThoai = @SoDienThoai, 
        Email = @Email, 
        GhiChu = @GhiChu 
    WHERE MaNCC = @MaNCC";

using (SqlConnection conn = new SqlConnection(chuoiketnoi))
{
    using (SqlCommand cmd = new SqlCommand(query, conn))
    {
        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
        cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNCC);
        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

        try
        {
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhaCungCap();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp có mã: " + maNCC, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();

            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!");
                            LoadNhaCungCap();
                            ClearForm(); // nếu có hàm clear
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp cần xóa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            string tenNCC = txtTenNCC.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            if (maNCC == "" || tenNCC == "")
            {
                MessageBox.Show("Mã NCC và Tên NCC không được để trống!");
                return;
            }

            string query = @"INSERT INTO NhaCungCap (MaNCC, TenNhaCungCap, DiaChi, SoDienThoai, Email, GhiChu)
                     VALUES (@MaNCC, @TenNhaCungCap, @DiaChi, @SoDienThoai, @Email, @GhiChu)";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNCC);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhà cung cấp thành công!");
                            LoadNhaCungCap();
                            txtMaNCC.Clear();
                            txtTenNCC.Clear();
                            txtDiaChi.Clear();
                            txtSoDienThoai.Clear();
                            txtEmail.Clear();
                            txtGhiChu.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công.");
                            txtMaNCC.Clear();
                            txtTenNCC.Clear();
                            txtDiaChi.Clear();
                            txtSoDienThoai.Clear();
                            txtEmail.Clear();
                            txtGhiChu.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
         
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells[0].Value?.ToString();
                txtTenNCC.Text = row.Cells[1].Value?.ToString();
                txtDiaChi.Text = row.Cells[2].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value?.ToString();
                txtGhiChu.Text = row.Cells[5].Value?.ToString();
            }
        }

     
        private void TimKiemNCC()
        {
            string tuKhoa = txtTenTimKiem.Text.Trim().ToLower();

            string query = @"SELECT * FROM NhaCungCap";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Tạo bản sao để lọc dữ liệu
                DataTable dtLoc = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    string tenNCC = row["TenNhaCungCap"]?.ToString() ?? "";

                    string hoTenKhongDau = BoDauTiengViet(tenNCC).ToLower();
                    string tuKhoaKhongDau = BoDauTiengViet(tuKhoa).ToLower();

                    bool hopTen = string.IsNullOrEmpty(tuKhoa) || hoTenKhongDau.Contains(tuKhoaKhongDau);

                    if (hopTen)
                    {
                        dtLoc.ImportRow(row);
                    }
                }

                dataGridView1.DataSource = dtLoc;
            }

            if (dataGridView1.Columns.Count >= 6)
            {
                dataGridView1.Columns[0].HeaderText = "Mã NCC";
                dataGridView1.Columns[1].HeaderText = "Tên NCC";
                dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns[4].HeaderText = "Email";
                dataGridView1.Columns[5].HeaderText = "Ghi Chú";
            }
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

        private void txtTenTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemNCC();
        }

        private void txtTenTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            TimKiemNCC();
        }
    }
}

