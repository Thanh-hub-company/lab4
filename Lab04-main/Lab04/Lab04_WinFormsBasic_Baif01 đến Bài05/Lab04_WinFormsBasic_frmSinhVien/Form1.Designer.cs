namespace Lab04_WinFormsBasic_frmSinhVien
{
    partial class Form1
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
            this.infor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnSoThich = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.infor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // infor
            // 
            this.infor.Controls.Add(this.textBox1);
            this.infor.Controls.Add(this.comboBox1);
            this.infor.Controls.Add(this.radNu);
            this.infor.Controls.Add(this.radNam);
            this.infor.Controls.Add(this.label6);
            this.infor.Controls.Add(this.dtpNgaySinh);
            this.infor.Controls.Add(this.txtHoTen);
            this.infor.Controls.Add(this.txtMaSV);
            this.infor.Controls.Add(this.label5);
            this.infor.Controls.Add(this.label4);
            this.infor.Controls.Add(this.label3);
            this.infor.Controls.Add(this.label2);
            this.infor.Controls.Add(this.label1);
            this.infor.Location = new System.Drawing.Point(12, 12);
            this.infor.Name = "infor";
            this.infor.Size = new System.Drawing.Size(355, 222);
            this.infor.TabIndex = 0;
            this.infor.TabStop = false;
            this.infor.Text = "Thông tin cá nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoThich);
            this.groupBox1.Controls.Add(this.btnSoThich);
            this.groupBox1.Controls.Add(this.chkLapTrinh);
            this.groupBox1.Controls.Add(this.chkTheThao);
            this.groupBox1.Controls.Add(this.chkDocSach);
            this.groupBox1.Location = new System.Drawing.Point(22, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở thích";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChonAnh);
            this.groupBox2.Controls.Add(this.txtDuongDanAnh);
            this.groupBox2.Controls.Add(this.picAnh);
            this.groupBox2.Location = new System.Drawing.Point(416, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 349);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh đại diện";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(78, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(172, 20);
            this.txtMaSV.TabIndex = 5;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(78, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(172, 20);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(78, 83);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 10;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tuổi";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(80, 151);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 12;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(146, 151);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 13;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(7, 20);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.Size = new System.Drawing.Size(72, 17);
            this.chkDocSach.TabIndex = 0;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            this.chkDocSach.CheckedChanged += new System.EventHandler(this.chkDocSach_CheckedChanged);
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(243, 20);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(69, 17);
            this.chkTheThao.TabIndex = 1;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            this.chkTheThao.CheckedChanged += new System.EventHandler(this.chkTheThao_CheckedChanged);
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(122, 19);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.Size = new System.Drawing.Size(67, 17);
            this.chkLapTrinh.TabIndex = 2;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            this.chkLapTrinh.CheckedChanged += new System.EventHandler(this.chkLapTrinh_CheckedChanged);
            // 
            // btnSoThich
            // 
            this.btnSoThich.Location = new System.Drawing.Point(7, 59);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(108, 23);
            this.btnSoThich.TabIndex = 3;
            this.btnSoThich.Text = "Kiểm tra sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoThich.Location = new System.Drawing.Point(119, 64);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(48, 13);
            this.lblSoThich.TabIndex = 4;
            this.lblSoThich.Text = "Sở thích";
            this.lblSoThich.Click += new System.EventHandler(this.lblSoThich_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(22, 37);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(196, 248);
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(22, 291);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.Size = new System.Drawing.Size(196, 20);
            this.txtDuongDanAnh.TabIndex = 1;
            this.txtDuongDanAnh.TextChanged += new System.EventHandler(this.txtDuongDanAnh_TextChanged);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(87, 317);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(73, 23);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(252, 387);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(166, 23);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển thị thông tin";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 451);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infor);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.infor.ResumeLayout(false);
            this.infor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Button btnSoThich;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnHienThi;
    }
}

