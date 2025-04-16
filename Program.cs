using QLCH_NuocGiaiKhat.Forms.QuanLy;
using QLCH_NuocGiaiKhat.Forms.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
