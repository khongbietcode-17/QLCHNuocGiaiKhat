using System.Drawing;
using System.Windows.Forms;

namespace QLCH_NuocGiaiKhat.Forms.Shared
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTaiKhoan;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblThongBao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.BackColor = System.Drawing.Color.White;
            this.pnlTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaiKhoan.Controls.Add(this.picUser);
            this.pnlTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.pnlTaiKhoan.Location = new System.Drawing.Point(39, 261);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(260, 40);
            this.pnlTaiKhoan.TabIndex = 2;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(5, 4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(32, 32);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(45, 10);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(210, 18);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.White;
            this.pnlMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatKhau.Controls.Add(this.picLock);
            this.pnlMatKhau.Controls.Add(this.txtMatKhau);
            this.pnlMatKhau.Controls.Add(this.picEye);
            this.pnlMatKhau.Location = new System.Drawing.Point(39, 318);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(260, 40);
            this.pnlMatKhau.TabIndex = 3;
            // 
            // picLock
            // 
            this.picLock.Image = ((System.Drawing.Image)(resources.GetObject("picLock.Image")));
            this.picLock.Location = new System.Drawing.Point(5, 4);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(32, 32);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLock.TabIndex = 0;
            this.picLock.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(45, 10);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(170, 18);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // picEye
            // 
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = ((System.Drawing.Image)(resources.GetObject("picEye.Image")));
            this.picEye.Location = new System.Drawing.Point(225, 7);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(24, 24);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 2;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(39, 392);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(260, 40);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(39, 361);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(260, 27);
            this.lblThongBao.TabIndex = 5;
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(70, 16);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐÓNG PHẦN MỀM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 22.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(39, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "ĐĂNG NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(340, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlTaiKhoan);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlTaiKhoan.ResumeLayout(false);
            this.pnlTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlMatKhau.ResumeLayout(false);
            this.pnlMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}
