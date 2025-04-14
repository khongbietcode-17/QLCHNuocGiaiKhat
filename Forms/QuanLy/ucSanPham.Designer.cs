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
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(30, 3);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(167, 65);
            this.picSanPham.TabIndex = 0;
            this.picSanPham.TabStop = false;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(30, 75);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(35, 13);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "label1";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(30, 92);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(35, 13);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "label2";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(30, 105);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(35, 13);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "label3";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(30, 118);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(35, 13);
            this.lblGhiChu.TabIndex = 4;
            this.lblGhiChu.Text = "label4";
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picSanPham);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(255, 167);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblGia;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label lblGhiChu;
        public System.Windows.Forms.PictureBox picSanPham;

    }
}
