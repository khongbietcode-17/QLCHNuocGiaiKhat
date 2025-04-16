namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    partial class ucSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenSP.Location = new System.Drawing.Point(18, 187);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(57, 21);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "label1";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMaSP.Location = new System.Drawing.Point(19, 214);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(44, 15);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "label3";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Gold;
            this.lblSoLuong.Location = new System.Drawing.Point(19, 286);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(44, 15);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "label2";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNCC.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMaNCC.Location = new System.Drawing.Point(19, 238);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(44, 15);
            this.lblMaNCC.TabIndex = 8;
            this.lblMaNCC.Text = "label2";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblDonViTinh.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDonViTinh.Location = new System.Drawing.Point(19, 262);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(44, 15);
            this.lblDonViTinh.TabIndex = 9;
            this.lblDonViTinh.Text = "label2";
            // 
            // picSanPham
            // 
            this.picSanPham.BackColor = System.Drawing.Color.Transparent;
            this.picSanPham.Location = new System.Drawing.Point(20, 10);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(170, 170);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 0;
            this.picSanPham.TabStop = false;
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.BackgroundImage = global::QLCH_NuocGiaiKhat.Properties.Resources.Thiết_kế_chưa_có_tên__2_;
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picSanPham);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(210, 316);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.PictureBox picSanPham;
        public System.Windows.Forms.Label lblSoLuong;
        public System.Windows.Forms.Label lblMaNCC;
        public System.Windows.Forms.Label lblDonViTinh;
    }
}
