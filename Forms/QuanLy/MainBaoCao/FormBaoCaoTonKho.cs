using Microsoft.Reporting.WinForms;
using System;
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

namespace QLCH_NuocGiaiKhat.Forms.QuanLy.MainBaoCao
{
    public partial class FormBaoCaoTonKho: Form
    {
        string chuoiketnoi = "Data Source=LAPTOP-KNSIOEA3;Initial Catalog=CuaHangNuocGiaiKhat;Integrated Security=True";
        public FormBaoCaoTonKho()
        {
            InitializeComponent();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Controls.Add(this.reportViewer1);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
        }
        private DataTable GetTonKhoData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string query = @"
            SELECT 
                MaSP, 
                TenSanPham, 
                Loai, 
                DonViTinh, 
                GiaNhap, 
                GiaBan, 
                SoLuong, 
                MaNCC
            FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
        private void FormBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            DataTable dt = GetTonKhoData();

            string reportPath = @"D:\Code C#\QLCHNuocGiaiKhat\rptTonKho.rdlc"; // hoặc dùng Path.Combine
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = reportPath;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("TonKhoDataSet", dt)
            );

            reportViewer1.Visible = true;
            reportViewer1.Dock = DockStyle.Fill;

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

         

        }


    }
}
