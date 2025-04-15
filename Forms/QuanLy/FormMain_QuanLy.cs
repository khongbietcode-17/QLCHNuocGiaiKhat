using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{


    public partial class FormMain_QuanLy: Form
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
            lblTen.Text =_hoten; // Hiển thị tên người dùng vào lblTen
        }

        private void FormMain_QuanLy_Load(object sender, EventArgs e)
        {

        }
     

        // Code Chuyển Động 
        bool sidebarExpand = true;
        private void siderbarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sider.Width -= 10;
                if(sider.Width <=60)
                {
                    sidebarExpand = false;
                    siderbarTransition.Stop();
                    pnQLNCC.Width = sider.Width;
                    pnQLNV.Width = sider.Width;
                    pnQLSP.Width = sider.Width;
                    pnTKDS.Width = sider.Width;
                }
            }
            else
            {
                sider.Width += 10;
                if(sider.Width >= 259)
                {
                    sidebarExpand = true;
                    siderbarTransition.Stop();
                    pnQLNCC.Width = sider.Width;
                    pnQLNV.Width = sider.Width;
                    pnQLSP.Width = sider.Width;
                    pnTKDS.Width = sider.Width;

                }
            }
        }


        // Xử Lý Nhấn Vào Thanh Chọn 
        private void btnQLNV_Click(object sender, EventArgs e)
        {
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

            panel3.Controls.Clear(); // Xóa form cũ nếu có trong panel
            panel3.Controls.Add(QLNhanVien);
            QLNhanVien.Show();
        }

        private void QLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLNhanVien = null;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
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

            panel3.Controls.Clear(); // Clear panel trước khi add form mới
            panel3.Controls.Add(ThongKeDoanhSo);
            ThongKeDoanhSo.Show();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
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

            panel3.Controls.Clear(); // Xóa form cũ
            panel3.Controls.Add(QLNhaCungCap);
            QLNhaCungCap.Show();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
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

            panel3.Controls.Clear(); // Xóa form đang hiển thị trong panel
            panel3.Controls.Add(QLSanPham);
            QLSanPham.Show();
        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            siderbarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
    }
}
