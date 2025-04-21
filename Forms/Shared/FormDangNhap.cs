using AForge.Video;
using AForge.Video.DirectShow;
using QLCH_NuocGiaiKhat.CustomBackgroud;
using QLCH_NuocGiaiKhat.Forms.NhanVien;
using QLCH_NuocGiaiKhat.Forms.QuanLy;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.Shared
{
    public partial class FormDangNhap : Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        private bool matKhauDangAn = true;
        private VideoCaptureDevice videoSource;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            this.Width = screen.Width;
            this.Height = screen.Height;
            this.Location = new Point(0, 0);

            GradientPanel panelChinh = new GradientPanel();
            panelChinh.Dock = DockStyle.Fill;
            this.Controls.Add(panelChinh);
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            this.FormClosing += FormClosingHandler;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = @"
SELECT Nguoidung.Vaitro, ThongTinNguoiDung.HoTen 
FROM Nguoidung
INNER JOIN ThongTinNguoiDung ON Nguoidung.Id = ThongTinNguoiDung.IdNguoiDung 
WHERE Nguoidung.Taikhoan = @tk AND Nguoidung.Matkhau = @mk";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tk", taikhoan);
                cmd.Parameters.AddWithValue("@mk", matkhau);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string vaitro = reader["Vaitro"].ToString();
                    string hoten = reader["HoTen"].ToString();

                    this.Hide();

                    if (vaitro == "QuanLy")
                    {
                        using (FormMain_QuanLy formQL = new FormMain_QuanLy(hoten))
                            formQL.ShowDialog();
                    }
                    else if (vaitro == "NhanVien")
                    {
                        using (FormMain_NhanVien formNV = new FormMain_NhanVien(hoten))
                            formNV.ShowDialog();
                    }

                    this.Show();
                }
                else
                {
                    lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                    lblThongBao.ForeColor = Color.Red;
                }

                reader.Close();
            }
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            matKhauDangAn = !matKhauDangAn;
            txtMatKhau.UseSystemPasswordChar = matKhauDangAn;
            picEye.Image = matKhauDangAn ? Properties.Resources.eye : Properties.Resources.hidden;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var formQR = new QuetQR())
            {
                if (formQR.ShowDialog() == DialogResult.OK)
                {
                    string scannedID = formQR.Tag.ToString();

                    using (SqlConnection conn = new SqlConnection(chuoiketnoi))
                    {
                        string query = @"
SELECT Nguoidung.Vaitro, ThongTinNguoiDung.HoTen 
FROM Nguoidung 
INNER JOIN ThongTinNguoiDung ON Nguoidung.ID = ThongTinNguoiDung.IDNguoiDung 
WHERE Nguoidung.ID = @id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", scannedID);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string vaitro = reader["Vaitro"].ToString();
                            string hoten = reader["HoTen"].ToString();

                            this.Hide(); // Ẩn form đăng nhập

                            if (vaitro == "QuanLy")
                            {
                                using (FormMain_QuanLy formQL = new FormMain_QuanLy(hoten))
                                {
                                    formQL.ShowDialog();
                                }
                            }
                            else if (vaitro == "NhanVien")
                            {
                                using (FormMain_NhanVien formNV = new FormMain_NhanVien(hoten))
                                {
                                    formNV.ShowDialog();
                                }
                            }

                            this.Show(); // Hiện lại form đăng nhập
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng với ID này!");
                        }

                        reader.Close();
                    }
                }
            }
        }
    }
}