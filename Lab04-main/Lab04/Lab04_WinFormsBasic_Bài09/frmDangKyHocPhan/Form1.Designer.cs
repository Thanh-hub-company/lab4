namespace frmDangKyHocPhan
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
            this.chklbHocPhan = new System.Windows.Forms.CheckedListBox();
            this.lblTongTinChi = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbHocPhan
            // 
            this.chklbHocPhan.FormattingEnabled = true;
            this.chklbHocPhan.Location = new System.Drawing.Point(25, 23);
            this.chklbHocPhan.Name = "chklbHocPhan";
            this.chklbHocPhan.Size = new System.Drawing.Size(218, 109);
            this.chklbHocPhan.TabIndex = 0;
            this.chklbHocPhan.SelectedIndexChanged += new System.EventHandler(this.chklbHocPhan_SelectedIndexChanged);
            // 
            // lblTongTinChi
            // 
            this.lblTongTinChi.AutoSize = true;
            this.lblTongTinChi.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTinChi.Location = new System.Drawing.Point(31, 156);
            this.lblTongTinChi.Name = "lblTongTinChi";
            this.lblTongTinChi.Size = new System.Drawing.Size(56, 13);
            this.lblTongTinChi.TabIndex = 1;
            this.lblTongTinChi.Text = "Tổng kết: ";
            this.lblTongTinChi.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(181, 192);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(62, 27);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Xác nhận";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 234);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblTongTinChi);
            this.Controls.Add(this.chklbHocPhan);
            this.Name = "Form1";
            this.Text = "Form Đăng ký Học phần";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbHocPhan;
        private System.Windows.Forms.Label lblTongTinChi;
        private System.Windows.Forms.Button btnDangKy;
    }
}

