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
        FormQLNhanVien QLNhanVien;
        FormQLNhaCungCap QLNhaCungCap;
        FormQLSanPham QLSanPham;
        FormThongKeDoanhSo ThongKeDoanhSo;
        public FormMain_QuanLy()
        {
            InitializeComponent();
        }

        private void FormMain_QuanLy_Load(object sender, EventArgs e)
        {

        }
        private string _username;
        public FormMain_QuanLy(string username)
        {
            InitializeComponent();
            _username = username;
            
        }
        // Code Chuyển Động 
        bool sidebarExpand = true;
        private void siderbarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanel1.Width -= 10;
                if(flowLayoutPanel1.Width <=50)
                {
                    sidebarExpand = false;
                    siderbarTransition.Stop();
                    pnQLNCC.Width = flowLayoutPanel1.Width;
                    pnQLNV.Width = flowLayoutPanel1.Width;
                    pnQLSP.Width = flowLayoutPanel1.Width;
                    pnTKDS.Width = flowLayoutPanel1.Width;
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if(flowLayoutPanel1.Width >= 187)
                {
                    sidebarExpand = true;
                    siderbarTransition.Stop();
                    pnQLNCC.Width = flowLayoutPanel1.Width;
                    pnQLNV.Width = flowLayoutPanel1.Width;
                    pnQLSP.Width = flowLayoutPanel1.Width;
                    pnTKDS.Width = flowLayoutPanel1.Width;

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
