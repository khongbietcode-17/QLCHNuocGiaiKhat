using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.NhanVien
{
    public partial class FormMain_NhanVien: Form
    {
        public FormMain_NhanVien()
        {
            InitializeComponent();
        }

        private void FormMain_NhanVien_Load(object sender, EventArgs e)
        {

        }
        private string _username;
        public FormMain_NhanVien(string username)
        {
            InitializeComponent();
            _username = username;
        }
    }
}
