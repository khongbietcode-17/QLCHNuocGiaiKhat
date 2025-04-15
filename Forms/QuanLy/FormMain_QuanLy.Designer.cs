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
            this.pnQLNV = new System.Windows.Forms.Panel();
            this.pnTKDS = new System.Windows.Forms.Panel();
            this.pnQLSP = new System.Windows.Forms.Panel();
            this.pnQLNCC = new System.Windows.Forms.Panel();
            this.siderbarTransition = new System.Windows.Forms.Timer(this.components);
            this.sider = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.pnQLNV.SuspendLayout();
            this.pnTKDS.SuspendLayout();
            this.pnQLSP.SuspendLayout();
            this.pnQLNCC.SuspendLayout();
            this.sider.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnQLNV
            // 
            this.pnQLNV.BackColor = System.Drawing.Color.MediumPurple;
            this.pnQLNV.Controls.Add(this.btnQLNV);
            this.pnQLNV.Location = new System.Drawing.Point(3, 261);
            this.pnQLNV.Name = "pnQLNV";
            this.pnQLNV.Size = new System.Drawing.Size(252, 46);
            this.pnQLNV.TabIndex = 2;
            // 
            // pnTKDS
            // 
            this.pnTKDS.BackColor = System.Drawing.Color.MediumPurple;
            this.pnTKDS.Controls.Add(this.btnThongKe);
            this.pnTKDS.Location = new System.Drawing.Point(3, 365);
            this.pnTKDS.Name = "pnTKDS";
            this.pnTKDS.Size = new System.Drawing.Size(252, 46);
            this.pnTKDS.TabIndex = 5;
            // 
            // pnQLSP
            // 
            this.pnQLSP.BackColor = System.Drawing.Color.MediumPurple;
            this.pnQLSP.Controls.Add(this.btnQLSP);
            this.pnQLSP.Location = new System.Drawing.Point(3, 313);
            this.pnQLSP.Name = "pnQLSP";
            this.pnQLSP.Size = new System.Drawing.Size(252, 46);
            this.pnQLSP.TabIndex = 4;
            // 
            // pnQLNCC
            // 
            this.pnQLNCC.BackColor = System.Drawing.Color.MediumPurple;
            this.pnQLNCC.Controls.Add(this.btnQLNCC);
            this.pnQLNCC.Location = new System.Drawing.Point(3, 417);
            this.pnQLNCC.Name = "pnQLNCC";
            this.pnQLNCC.Size = new System.Drawing.Size(252, 46);
            this.pnQLNCC.TabIndex = 3;
            // 
            // siderbarTransition
            // 
            this.siderbarTransition.Interval = 10;
            this.siderbarTransition.Tick += new System.EventHandler(this.siderbarTransition_Tick);
            // 
            // sider
            // 
            this.sider.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sider.Controls.Add(this.panel2);
            this.sider.Controls.Add(this.pictureBox2);
            this.sider.Controls.Add(this.panel1);
            this.sider.Controls.Add(this.pnQLNV);
            this.sider.Controls.Add(this.pnQLNCC);
            this.sider.Controls.Add(this.pnTKDS);
            this.sider.Controls.Add(this.pnQLSP);
            this.sider.Dock = System.Windows.Forms.DockStyle.Left;
            this.sider.Location = new System.Drawing.Point(0, 0);
            this.sider.Name = "sider";
            this.sider.Size = new System.Drawing.Size(259, 600);
            this.sider.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 46);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 600);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chào mừng bạn quay trở lại";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblTen.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTen.Location = new System.Drawing.Point(580, 261);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(145, 54);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "lblTen";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-5, -12);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(269, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "  XEM ĐẦY ĐỦ THÔNG TIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(-4, -14);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(269, 74);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLNCC.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQLNCC.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNCC.Image")));
            this.btnQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC.Location = new System.Drawing.Point(-6, -14);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLNCC.Size = new System.Drawing.Size(271, 74);
            this.btnQLNCC.TabIndex = 0;
            this.btnQLNCC.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.btnQLNCC.UseVisualStyleBackColor = false;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-6, -13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(271, 74);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "THỐNG KÊ DOANH SỐ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQLSP.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQLSP.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSP.Image")));
            this.btnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSP.Location = new System.Drawing.Point(-6, -13);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLSP.Size = new System.Drawing.Size(271, 74);
            this.btnQLSP.TabIndex = 0;
            this.btnQLSP.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // FormMain_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sider);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormMain_QuanLy";
            this.Load += new System.EventHandler(this.FormMain_QuanLy_Load);
            this.pnQLNV.ResumeLayout(false);
            this.pnTKDS.ResumeLayout(false);
            this.pnQLSP.ResumeLayout(false);
            this.pnQLNCC.ResumeLayout(false);
            this.sider.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnQLNV;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Panel pnQLNCC;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Panel pnTKDS;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnQLSP;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Timer siderbarTransition;
        private System.Windows.Forms.Panel sider;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}