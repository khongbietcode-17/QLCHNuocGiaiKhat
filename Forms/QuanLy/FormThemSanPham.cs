using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    public partial class FormThemSanPham: Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormThemSanPham()
        {
            InitializeComponent();
        }
   
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
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
                         //   LoadDanhSachSanPham();
                            //ClearFormSanPham();
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
            this.Close();
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

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            LoadNhaCungCapVaoComboBox();
        }
    }
}
