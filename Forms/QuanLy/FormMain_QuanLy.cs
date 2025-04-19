using QLCH_NuocGiaiKhat.CustomBackgroud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{


    public partial class FormMain_QuanLy : Form
    {
        private string _hoten;
        FormQLNhanVien QLNhanVien;
        FormQLNhaCungCap QLNhaCungCap;
        FormQLSanPham QLSanPham;
        FormThongKeDoanhSo ThongKeDoanhSo;
        public FormMain_QuanLy(string hoten)
        {
            InitializeComponent();
            _hoten = hoten;
            lblTen.Text = _hoten; // Hiển thị tên người dùng vào lblTen
        }

        private void FormMain_QuanLy_Load(object sender, EventArgs e)
        {
 

            panelChuyenDong.Location = button4.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = button4.Height;

            lblNhanVien.Text = GetCount("NguoiDung").ToString();
            lblNCC.Text = GetCount("NhaCungCap").ToString();
            lblSP.Text = GetCount("SanPham").ToString();
            LoadSoDoTron();
         
            
        }
        private int GetCount(string tableName)
        {
            string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
            int count = 0;
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        // Code Chuyển Động 
        bool sidebarExpand = true;
        private void siderbarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sider.Width -= 10;
                if (sider.Width <= 60)
                {
                    sidebarExpand = false;
                    siderbarTransition.Stop();
              
                }
            }
            else
            {
                sider.Width += 10;
                if (sider.Width >= 259)
                {
                    sidebarExpand = true;
                    siderbarTransition.Stop();
  

                }
            }
        }


        // Xử Lý Nhấn Vào Thanh Chọn 
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            panelChuyenDong.Location = btnQLNV.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = btnQLNV.Height;
            // Nếu form đã được khởi tạo trước đó, đóng lại để làm mới
            if (QLNhanVien != null)
            {
                QLNhanVien.Close();
                QLNhanVien.Dispose();
            }

            QLNhanVien = new FormQLNhanVien();
            QLNhanVien.TopLevel = false;
            QLNhanVien.FormBorderStyle = FormBorderStyle.None;
            QLNhanVien.Dock = DockStyle.Fill;

            CloseEmbeddedForms(panel3);
            panel3.Controls.Add(QLNhanVien);
            QLNhanVien.Show();
            QLNhanVien.BringToFront();
        }

        private void QLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLNhanVien = null;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panelChuyenDong.Location = btnThongKe.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = btnThongKe.Height;
            // Nếu form đã được mở trước đó thì đóng và khởi tạo lại
            if (ThongKeDoanhSo != null)
            {
                ThongKeDoanhSo.Close();
                ThongKeDoanhSo.Dispose();
            }

            ThongKeDoanhSo = new FormThongKeDoanhSo();
            ThongKeDoanhSo.TopLevel = false;
            ThongKeDoanhSo.FormBorderStyle = FormBorderStyle.None;
            ThongKeDoanhSo.Dock = DockStyle.Fill;
            CloseEmbeddedForms(panel3);
            panel3.Controls.Add(ThongKeDoanhSo);
            ThongKeDoanhSo.Show();
            ThongKeDoanhSo.BringToFront();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            panelChuyenDong.Location = btnQLNCC.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = btnQLNCC.Height;
            // Nếu form đã được mở, đóng lại để làm mới
            if (QLNhaCungCap != null)
            {
                QLNhaCungCap.Close();
                QLNhaCungCap.Dispose();
            }

            QLNhaCungCap = new FormQLNhaCungCap();
            QLNhaCungCap.TopLevel = false;
            QLNhaCungCap.FormBorderStyle = FormBorderStyle.None;
            QLNhaCungCap.Dock = DockStyle.Fill;

            CloseEmbeddedForms(panel3);
            panel3.Controls.Add(QLNhaCungCap);
            QLNhaCungCap.Show();
            QLNhaCungCap.BringToFront();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            panelChuyenDong.Location = btnQLSP.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = btnQLSP.Height;
            // Nếu form đã được khởi tạo trước đó, đóng lại để làm mới
            if (QLSanPham != null)
            {
                QLSanPham.Close();
                QLSanPham.Dispose();
            }

            QLSanPham = new FormQLSanPham();
            QLSanPham.TopLevel = false;
            QLSanPham.FormBorderStyle = FormBorderStyle.None;
            QLSanPham.Dock = DockStyle.Fill;

            CloseEmbeddedForms(panel3);
            panel3.Controls.Add(QLSanPham);
            QLSanPham.Show();
            QLSanPham.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelChuyenDong.Location = button3.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = button3.Height;
            siderbarTransition.Start();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            panelChuyenDong.Location = button4.Location;
            panelChuyenDong.Visible = true;
            panelChuyenDong.BringToFront();
            panelChuyenDong.Height = button4.Height;

            CloseEmbeddedForms(panel3);
            lblNhanVien.Text = GetCount("NguoiDung").ToString();
            lblNCC.Text = GetCount("NhaCungCap").ToString();
            lblSP.Text = GetCount("SanPham").ToString();
            LoadSoDoTron();
        }
        private void CloseEmbeddedForms(Panel container)
        {
            foreach (Control ctrl in container.Controls.OfType<Form>().ToList())
            {
                ctrl.Dispose();
            }
        }
        private void LoadSoDoTron()
        {
            string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = @"SELECT MaNCC, SUM(SoLuong) AS TongSoLuong
                         FROM SanPham
                         GROUP BY MaNCC";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNCC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
