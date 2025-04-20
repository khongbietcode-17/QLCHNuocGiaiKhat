using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QLCH_NuocGiaiKhat.Forms.QuanLy;
using System.Runtime.InteropServices;
namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{

    public partial class FormQLSanPham: Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormQLSanPham()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSanPham form = new FormThemSanPham();
            form.ShowDialog();
            LoadSanPhamCard();
        }
        private void LoadDanhSachSanPham()
        {
            string query = "SELECT * FROM SanPham";

        }
        private void FormQLSanPham_Load(object sender, EventArgs e)
        {

            LoadDanhSachSanPham();
            LoadSanPhamCard();

            flowSanPham.AutoScroll = true; // ✅ phải có dòng này
            ScrollBarHider.HideVerticalScrollBar(flowSanPham); // ẩn thanh cuộn
            flowSanPham.Scroll += (s, ev) =>
            {
                ScrollBarHider.HideVerticalScrollBar(flowSanPham);
            };
            flowSanPham.Layout += (s, ev) =>
            {
                ScrollBarHider.HideVerticalScrollBar(flowSanPham);
            };
        }

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




        private void LoadSanPhamCard()
        {
            flowSanPham.Controls.Clear();

            string query = "SELECT * FROM SanPham";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ucSanPham spCard = new ucSanPham();

                    // Gán dữ liệu từ SQL vào control của UserControl
                    spCard.lblMaSP.Text = "Mã Sản Phẩm: " + reader["MaSP"].ToString();
                    spCard.lblTenSP.Text = reader["TenSanPham"].ToString();
                 
                    spCard.lblDonViTinh.Text = "Đơn Vị Tính: " + reader["DonViTinh"].ToString();
                  
                    spCard.lblSoLuong.Text = "Số Lượng: " + reader["SoLuong"].ToString();
                    spCard.lblMaNCC.Text = "Mã NCC: " + reader["MaNCC"].ToString();
                   

                    // Lưu MaSP để xử lý khi click
                    spCard.Tag = reader["MaSP"].ToString();

                    // Xử lý hình ảnh
                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            spCard.picSanPham.Image = Image.FromStream(ms);
                        }
                    }

                    // Bắt sự kiện click
                    spCard.Click += SpCard_Click;

                    // Thêm thẻ vào FlowLayoutPanel
                    flowSanPham.Controls.Add(spCard);
                }

                reader.Close();
            }
        
        }

        private void SpCard_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string maSP = "";

            if (control is ucSanPham)
                maSP = control.Tag?.ToString();
            else
                maSP = control.Parent?.Tag?.ToString();

            if (maSP == null || maSP == "")
                return;

            string query = "SELECT * FROM SanPham WHERE MaSP = @MaSP";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMaSP.Text = reader["MaSP"].ToString();
                    txtTenSP.Text = reader["TenSanPham"].ToString();
                    cboSoLuong.Text = reader["SoLuong"].ToString();

                    // Load ảnh nếu có
                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            picHinhAnh.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picHinhAnh.Image = null;
                    }
                }

                reader.Close();
            }

        }





        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongThem = (int)nudSoLuongThem.Value;

            if (soLuongThem <= 0)
            {
                MessageBox.Show("Số lượng thêm phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiketnoi))
                {
                    conn.Open();

                    // Cập nhật số lượng mới
                    string query = "UPDATE SanPham SET SoLuong = SoLuong + @SoLuongThem WHERE MaSP = @MaSP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoLuongThem", soLuongThem);
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đã cập nhật số lượng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachSanPham();
                            LoadSanPhamCard();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboSoLuong.Value = 0;
            picHinhAnh.Image = null;
            nudSoLuongThem.Value = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == null || txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSP = txtMaSP.Text.Trim();

                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";

                using (SqlConnection conn = new SqlConnection(chuoiketnoi))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachSanPham(); // refresh lại DataGridView
                        LoadSanPhamCard();     // refresh lại danh sách card
                        ClearTextBoxes();      // xoá nội dung trong các textbox
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboSoLuong.Value = 0;
            picHinhAnh.Image = null;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            LoadSanPhamCard(keyword); // gọi lại Load với từ khóa tìm kiếm
        }
        private void LoadSanPhamCard(string keyword = "")
        {
            flowSanPham.Controls.Clear();

            string query = "SELECT * FROM SanPham WHERE TenSanPham COLLATE Latin1_General_CI_AI LIKE @keyword";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ucSanPham spCard = new ucSanPham();

                    spCard.lblMaSP.Text = "Mã Sản Phẩm: " + reader["MaSP"].ToString();
                    spCard.lblTenSP.Text = reader["TenSanPham"].ToString();
                    spCard.lblDonViTinh.Text = "Đơn Vị Tính: " + reader["DonViTinh"].ToString();
                    spCard.lblSoLuong.Text = "Số Lượng: " + reader["SoLuong"].ToString();
                    spCard.lblMaNCC.Text = "Mã NCC: " + reader["MaNCC"].ToString();

                    // Gán Tag
                    spCard.Tag = reader["MaSP"].ToString();

                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            spCard.picSanPham.Image = Image.FromStream(ms);
                        }
                    }

                    // Gán sự kiện click
                    spCard.Click += SpCard_Click;
                    foreach (Control ctrl in spCard.Controls)
                    {
                        ctrl.Click += SpCard_Click;
                    }

                    flowSanPham.Controls.Add(spCard);
                }

                reader.Close();
            }
        }


    }
}

