namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    partial class FormChupAnh
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
            this.cboCam = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChup = new System.Windows.Forms.Button();
            this.picCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCam
            // 
            this.cboCam.FormattingEnabled = true;
            this.cboCam.Location = new System.Drawing.Point(33, 340);
            this.cboCam.Name = "cboCam";
            this.cboCam.Size = new System.Drawing.Size(300, 21);
            this.cboCam.TabIndex = 3;
            this.cboCam.SelectedIndexChanged += new System.EventHandler(this.cboCam_SelectedIndexChanged);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.cancel2;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(189, 375);
            this.btnDong.Name = "btnDong";
            this.btnDong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDong.Size = new System.Drawing.Size(144, 40);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChup
            // 
            this.btnChup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnChup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChup.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChup.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.photo_camera_interface_symbol_for_button2;
            this.btnChup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChup.Location = new System.Drawing.Point(33, 375);
            this.btnChup.Name = "btnChup";
            this.btnChup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnChup.Size = new System.Drawing.Size(150, 40);
            this.btnChup.TabIndex = 1;
            this.btnChup.Text = "Chụp Hình";
            this.btnChup.UseVisualStyleBackColor = false;
            this.btnChup.Click += new System.EventHandler(this.btnChup_Click_1);
            // 
            // picCam
            // 
            this.picCam.Location = new System.Drawing.Point(33, 25);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(300, 300);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam.TabIndex = 0;
            this.picCam.TabStop = false;
            // 
            // FormChupAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(365, 433);
            this.Controls.Add(this.cboCam);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChup);
            this.Controls.Add(this.picCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChupAnh";
            this.Text = "Chụp Ảnh";
            this.Load += new System.EventHandler(this.FormChupAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboCam;
        private System.Windows.Forms.Button btnChup;
    }
}