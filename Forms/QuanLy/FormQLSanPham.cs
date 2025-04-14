using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QLCH_NuocGiaiKhat.Forms.QuanLy;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{

    public partial class FormQLSanPham: Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormQLSanPham()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string loai = cboLoai.Text.Trim();
            string dvt = cboDonViTinh.Text.Trim();
            decimal giaNhap;
            decimal giaBan;
            int soLuong;
            string maNCC = cboMaNCC.SelectedValue?.ToString() ?? cboMaNCC.Text;
            string ghiChu = txtGhiChu.Text.Trim();

            if (maSP == "" || tenSP == "" || !decimal.TryParse(txtGiaNhap.Text, out giaNhap) ||
        !decimal.TryParse(txtGiaBan.Text, out giaBan) || !int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường bắt buộc!");
                return;
            }

            byte[] hinhAnh = null;
            if (picHinhAnh.Image != null)
            {
                hinhAnh = ImageToByteArray(picHinhAnh.Image);
            }


            string query = @"INSERT INTO SanPham 
                     (MaSP, TenSanPham, Loai, DonViTinh, GiaNhap, GiaBan, SoLuong, MaNCC, HinhAnh, GhiChu) 
                     VALUES 
                     (@MaSP, @TenSanPham, @Loai, @DonViTinh, @GiaNhap, @GiaBan, @SoLuong, @MaNCC, @HinhAnh, @GhiChu)";
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSP);
                    cmd.Parameters.AddWithValue("@Loai", loai);
                    cmd.Parameters.AddWithValue("@DonViTinh", dvt);
                    cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = (object)hinhAnh ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!");
                            LoadDanhSachSanPham();
                            ClearFormSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                    }
                }
            }
            LoadSanPhamCard();
        }
        private void LoadDanhSachSanPham()
        {
            string query = "SELECT MaSP, TenSanPham, Loai, DonViTinh, GiaNhap, GiaBan, SoLuong, MaNCC, HinhAnh, GhiChu FROM SanPham";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                // Chuyển cột hình ảnh sang kiểu ảnh
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["HinhAnh"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Hiển thị ảnh vừa khung

                // Cài lại tiêu đề các cột nếu cần
                dataGridView1.Columns["MaSP"].HeaderText = "Mã SP";
                // ...
                dataGridView1.Columns["HinhAnh"].HeaderText = "Hình ảnh";

            }

            // Đặt tiêu đề cột (nếu chưa làm trong Designer)
            dataGridView1.Columns[0].HeaderText = "Mã SP";
            dataGridView1.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns[2].HeaderText = "Loại";
            dataGridView1.Columns[3].HeaderText = "Đơn Vị Tính";
            dataGridView1.Columns[4].HeaderText = "Giá Nhập";
            dataGridView1.Columns[5].HeaderText = "Giá Bán";
            dataGridView1.Columns[6].HeaderText = "Số Lượng";
            dataGridView1.Columns[7].HeaderText = "Mã NCC";
            dataGridView1.Columns[8].HeaderText = "Ghi Chú";
        }
        private void ClearFormSanPham()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoai.SelectedIndex = -1;
            cboDonViTinh.SelectedIndex = -1;
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            //txtSoLuong.Clear(); // Bổ sung nếu bạn có ô số lượng
            cboMaNCC.SelectedIndex = -1; // Bổ sung nếu có ComboBox chọn nhà cung cấp
            txtGhiChu.Clear();
            picHinhAnh.Image = null;
        }
        private void LoadNhaCungCapVaoComboBox()
        {
            string query = "SELECT MaNCC, TenNhaCungCap FROM NhaCungCap";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaNCC.DataSource = dt;
                cboMaNCC.DisplayMember = "TenNCC";  // Hiển thị tên trong danh sách
                cboMaNCC.ValueMember = "MaNCC";     // Giá trị thực dùng khi lưu
                cboMaNCC.SelectedIndex = -1;        // Không chọn sẵn
            }
        }

        private void FormQLSanPham_Load(object sender, EventArgs e)
        {
            LoadNhaCungCapVaoComboBox();
            LoadDanhSachSanPham();
            LoadSanPhamCard();
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

                    // Set dữ liệu
                    spCard.lblTenSP.Text = reader["TenSanPham"].ToString();
                    spCard.lblGia.Text = reader["GiaBan"].ToString();
                    spCard.lblMaSP.Text = reader["MaSP"].ToString();
                    spCard.Tag = reader["MaSP"].ToString();
                    spCard.lblGhiChu.Text = reader["GhiChu"].ToString();

                    // Hình ảnh
                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            spCard.picSanPham.Image = Image.FromStream(ms);
                        }
                    }
                    spCard.Click += SpCard_Click;
                    // Thêm vào FlowLayoutPanel
                    flowSanPham.Controls.Add(spCard);
                 

                }

                reader.Close();
            }
        }

        private void SpCard_Click(object sender, EventArgs e)
        {
            // Lấy MaSP từ ucSanPham được click
            Control control = (Control)sender;
            string maSP = "";

            // Lấy đúng ucSanPham gốc nếu click vào Label, PictureBox, v.v.
            if (control is ucSanPham)
                maSP = control.Tag.ToString();
            else
                maSP = control.Parent.Tag.ToString();

            // Duyệt DataGridView để tìm và chọn dòng có MaSP trùng
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0]; // focus vào cell đầu tiên
                    break;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                cboLoai.Text = row.Cells["Loai"].Value.ToString();
                cboDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                cboMaNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString(); // Nếu dùng combo có ValueMember
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

                // Xử lý hình ảnh
                if (row.Cells["HinhAnh"].Value != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row.Cells["HinhAnh"].Value;
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
        }
    }
}

