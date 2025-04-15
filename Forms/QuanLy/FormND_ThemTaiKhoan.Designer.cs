namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    partial class FormND_ThemTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboVaitro = new System.Windows.Forms.ComboBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVaitro
            // 
            this.cboVaitro.FormattingEnabled = true;
            this.cboVaitro.Items.AddRange(new object[] {
            "NhanVien",
            "QuanLy"});
            this.cboVaitro.Location = new System.Drawing.Point(118, 214);
            this.cboVaitro.Name = "cboVaitro";
            this.cboVaitro.Size = new System.Drawing.Size(247, 21);
            this.cboVaitro.TabIndex = 6;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(118, 169);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(247, 28);
            this.txtMatkhau.TabIndex = 5;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(118, 123);
            this.txtTaikhoan.Multiline = true;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(247, 28);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÊM TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(25, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chức vụ:";
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTiep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTiep.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.n;
            this.btnTiep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiep.Location = new System.Drawing.Point(118, 261);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnTiep.Size = new System.Drawing.Size(155, 40);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp theo";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // FormND_ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImage = global::QLCH_NuocGiaiKhat.Properties.Resources.Chưa_có_tên__10_x_20_cm_;
            this.ClientSize = new System.Drawing.Size(394, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.cboVaitro);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormND_ThemTaiKhoan";
            this.Text = "FormND_ThemTaiKhoan";
            this.Load += new System.EventHandler(this.FormND_ThemTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.ComboBox cboVaitro;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}