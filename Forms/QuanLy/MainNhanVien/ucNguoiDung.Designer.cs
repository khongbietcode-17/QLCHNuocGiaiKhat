namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    partial class ucNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNguoiDung));
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.picND = new QLCH_NuocGiaiKhat.CustomBackgroud.CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picND)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Name = "lblID";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Name = "lblEmail";
            // 
            // lblHoTen
            // 
            resources.ApplyResources(this.lblHoTen, "lblHoTen");
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHoTen.Name = "lblHoTen";
            // 
            // lblSDT
            // 
            resources.ApplyResources(this.lblSDT, "lblSDT");
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSDT.Name = "lblSDT";
            // 
            // lblDiaChi
            // 
            resources.ApplyResources(this.lblDiaChi, "lblDiaChi");
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiaChi.Name = "lblDiaChi";
            // 
            // lblVaiTro
            // 
            resources.ApplyResources(this.lblVaiTro, "lblVaiTro");
            this.lblVaiTro.BackColor = System.Drawing.Color.Transparent;
            this.lblVaiTro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVaiTro.Name = "lblVaiTro";
            // 
            // picND
            // 
            this.picND.BackColor = System.Drawing.Color.Transparent;
            this.picND.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.picND.BorderSize = 0;
            resources.ApplyResources(this.picND, "picND");
            this.picND.Name = "picND";
            this.picND.TabStop = false;
            // 
            // ucNguoiDung
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.picND);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ucNguoiDung";
            this.Load += new System.EventHandler(this.ucNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblHoTen;
        public System.Windows.Forms.Label lblSDT;
        public System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Label lblVaiTro;
        public CustomBackgroud.CirclePictureBox picND;
    }
}
