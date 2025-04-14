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
            lblTen.Text = "Xin chào, " + _hoten; // Hiển thị tên người dùng vào lblTen
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
                if(sider.Width <=58)
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
                if(sider.Width >= 220)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            siderbarTransition.Start();
        }
        // Xử Lý Nhấn Vào Thanh Chọn 
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            if(QLNhanVien == null)
            {
                QLNhanVien = new FormQLNhanVien();
                QLNhanVien.FormClosed += QLNhanVien_FormClosed;
                QLNhanVien.MdiParent = this;
                QLNhanVien.WindowState = FormWindowState.Maximized;
                QLNhanVien.Show();
            }
            else
            {
                QLNhanVien.Activate();
            }
        }
        private void QLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLNhanVien = null;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (ThongKeDoanhSo == null)
            {
                ThongKeDoanhSo = new FormThongKeDoanhSo();
                ThongKeDoanhSo.FormClosed += (s, args) => ThongKeDoanhSo = null;
                ThongKeDoanhSo.MdiParent = this;
                ThongKeDoanhSo.WindowState = FormWindowState.Maximized;
                ThongKeDoanhSo.Show();
            }
            else ThongKeDoanhSo.Activate();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            if (QLNhaCungCap == null)
            {
                QLNhaCungCap = new FormQLNhaCungCap();
                QLNhaCungCap.FormClosed += (s, args) => QLNhaCungCap = null;
                QLNhaCungCap.MdiParent = this;
                QLNhaCungCap.WindowState = FormWindowState.Maximized;
                QLNhaCungCap.Show();
            }
            else QLNhaCungCap.Activate();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            if (QLSanPham == null)
            {
                QLSanPham = new FormQLSanPham();
                QLSanPham.FormClosed += (s, args) => QLSanPham = null;
                QLSanPham.MdiParent = this;
                QLSanPham.WindowState = FormWindowState.Maximized;
                QLSanPham.Show();
            }
            else QLSanPham.Activate();
        }
        //
    }
}
