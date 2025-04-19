
using QLCH_NuocGiaiKhat.CustomBackgroud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
  
    public partial class FormThemNhanVien: Form
    {
        public FormThemNhanVien()
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
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string ht = txtHoTen.Text.Trim();
            string em = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string cv = cboVaiTro.Text.Trim();

            byte[] hinhAnh = null;
            if (picHinhAnh.Image != null)
            {
                hinhAnh = ImageToByteArray(picHinhAnh.Image);
            }
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string query1 = @"INSERT INTO NguoiDung (TaiKhoan, MatKhau, VaiTro)
                          VALUES (@TaiKhoan, @MatKhau, @VaiTro);
                          SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);
                    cmd1.Parameters.AddWithValue("@TaiKhoan", tk);
                    cmd1.Parameters.AddWithValue("@MatKhau", mk);
                    cmd1.Parameters.AddWithValue("@VaiTro", cv);

                    int idNguoiDung = Convert.ToInt32(cmd1.ExecuteScalar());
                    string query2 = @"INSERT INTO ThongTinNguoiDung 
                        (IDNguoiDung, HoTen, Email, SoDienThoai, DiaChi, Anh)
                        VALUES (@ID, @HoTen, @Email, @SDT, @DiaChi, @Anh)";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                    cmd2.Parameters.AddWithValue("@ID", idNguoiDung);
                    cmd2.Parameters.AddWithValue("@HoTen", ht);
                    cmd2.Parameters.AddWithValue("@Email", em);
                    cmd2.Parameters.AddWithValue("@SDT", sdt);
                    cmd2.Parameters.AddWithValue("@DiaChi", dc);
                    cmd2.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = (object)hinhAnh ?? DBNull.Value;

                    cmd2.ExecuteNonQuery();
                    tran.Commit();
                    MessageBox.Show("Thêm người dùng thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }
       
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChupAnh f = new FormChupAnh();
            if (f.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = f.AnhDaChup;
            }
        }
    }
}
