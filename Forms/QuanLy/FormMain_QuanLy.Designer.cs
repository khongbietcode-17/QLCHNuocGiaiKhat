namespace QLCH_NuocGiaiKhat.Forms.QuanLy
{
    partial class FormMain_QuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_QuanLy));
            this.siderbarTransition = new System.Windows.Forms.Timer(this.components);
            this.sider = new System.Windows.Forms.Panel();
            this.panelChuyenDong = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNhanVie = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNCC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sider.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siderbarTransition
            // 
            this.siderbarTransition.Interval = 10;
            this.siderbarTransition.Tick += new System.EventHandler(this.siderbarTransition_Tick);
            // 
            // sider
            // 
            this.sider.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sider.Controls.Add(this.pictureBox7);
            this.sider.Controls.Add(this.btnThongKe);
            this.sider.Controls.Add(this.btnQLNCC);
            this.sider.Controls.Add(this.btnQLSP);
            this.sider.Controls.Add(this.button4);
            this.sider.Controls.Add(this.btnQLNV);
            this.sider.Controls.Add(this.button3);
            this.sider.Controls.Add(this.panelChuyenDong);
            this.sider.Controls.Add(this.panel2);
            this.sider.Dock = System.Windows.Forms.DockStyle.Left;
            this.sider.Location = new System.Drawing.Point(0, 0);
            this.sider.Name = "sider";
            this.sider.Size = new System.Drawing.Size(259, 600);
            this.sider.TabIndex = 9;
            // 
            // panelChuyenDong
            // 
            this.panelChuyenDong.BackColor = System.Drawing.Color.AliceBlue;
            this.panelChuyenDong.Location = new System.Drawing.Point(190, 507);
            this.panelChuyenDong.Name = "panelChuyenDong";
            this.panelChuyenDong.Size = new System.Drawing.Size(5, 5);
            this.panelChuyenDong.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 46);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 600);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello,";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(181, 32);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(165, 65);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "lblTen";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lblNhanVien);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblNhanVie);
            this.panel4.Location = new System.Drawing.Point(28, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 91);
            this.panel4.TabIndex = 10;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI Black", 23.75F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Location = new System.Drawing.Point(88, 33);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(58, 45);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "99";
            // 
            // lblNhanVie
            // 
            this.lblNhanVie.AutoSize = true;
            this.lblNhanVie.Font = new System.Drawing.Font("Segoe UI Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblNhanVie.ForeColor = System.Drawing.Color.White;
            this.lblNhanVie.Location = new System.Drawing.Point(88, 14);
            this.lblNhanVie.Name = "lblNhanVie";
            this.lblNhanVie.Size = new System.Drawing.Size(91, 21);
            this.lblNhanVie.TabIndex = 0;
            this.lblNhanVie.Text = "Nhân Viên";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(149)))));
            this.panel6.Controls.Add(this.lblSP);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(633, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 91);
            this.panel6.TabIndex = 11;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Font = new System.Drawing.Font("Segoe UI Black", 23.75F, System.Drawing.FontStyle.Bold);
            this.lblSP.ForeColor = System.Drawing.Color.Transparent;
            this.lblSP.Location = new System.Drawing.Point(89, 41);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(58, 45);
            this.lblSP.TabIndex = 4;
            this.lblSP.Text = "99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sản Phẩm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.lblNCC);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(330, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 91);
            this.panel5.TabIndex = 12;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI Black", 23.75F, System.Drawing.FontStyle.Bold);
            this.lblNCC.ForeColor = System.Drawing.Color.Transparent;
            this.lblNCC.Location = new System.Drawing.Point(91, 33);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(58, 45);
            this.lblNCC.TabIndex = 2;
            this.lblNCC.Text = "99";
            this.lblNCC.Click += new System.EventHandler(this.lblNCC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Cung Cấp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.u60;
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.p60;
            this.pictureBox4.Location = new System.Drawing.Point(21, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.b60;
            this.pictureBox3.Location = new System.Drawing.Point(21, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.AGU_removebg_preview1;
            this.pictureBox7.Location = new System.Drawing.Point(50, 16);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(160, 160);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-2, 392);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(261, 52);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "THỐNG KÊ DOANH SỐ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLNCC.FlatAppearance.BorderSize = 0;
            this.btnQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNCC.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQLNCC.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNCC.Image")));
            this.btnQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC.Location = new System.Drawing.Point(-2, 288);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLNCC.Size = new System.Drawing.Size(261, 52);
            this.btnQLNCC.TabIndex = 0;
            this.btnQLNCC.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.btnQLNCC.UseVisualStyleBackColor = false;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLSP.FlatAppearance.BorderSize = 0;
            this.btnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSP.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQLSP.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSP.Image")));
            this.btnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSP.Location = new System.Drawing.Point(-2, 340);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLSP.Size = new System.Drawing.Size(261, 52);
            this.btnQLSP.TabIndex = 0;
            this.btnQLSP.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.home;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(261, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "TRANG CHỦ QUẢN LÝ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQLNV.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(-2, 236);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(261, 52);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-2, 445);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(261, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "BẬT TÍNH NÂNG TÌM KIẾM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-5, -12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(269, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "ĐĂNG XUẤT TÀI KHOẢN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::QLCH_NuocGiaiKhat.Properties.Resources.Blue___White_Modern_Line_Chart_Graph__591_x_357_px___587_x_336_px_;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(28, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(587, 336);
            this.panel7.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCH_NuocGiaiKhat.Properties.Resources.LOẠI_SẢN_PHẨM_BÁN_RA;
            this.pictureBox2.Location = new System.Drawing.Point(633, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 336);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sider);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormMain_QuanLy";
            this.Load += new System.EventHandler(this.FormMain_QuanLy_Load);
            this.sider.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Timer siderbarTransition;
        private System.Windows.Forms.Panel sider;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChuyenDong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNhanVie;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
    }
}