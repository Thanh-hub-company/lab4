namespace frmTinhBMI
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
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhBMI = new System.Windows.Forms.Button();
            this.lblChiSo = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(82, 25);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(148, 20);
            this.txtChieuCao.TabIndex = 0;
            this.txtChieuCao.TextChanged += new System.EventHandler(this.txtChieuCao_TextChanged);
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(82, 67);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(148, 20);
            this.txtCanNang.TabIndex = 1;
            this.txtCanNang.TextChanged += new System.EventHandler(this.txtCanNang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiều cao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cân nặng";
            // 
            // btnTinhBMI
            // 
            this.btnTinhBMI.Location = new System.Drawing.Point(129, 175);
            this.btnTinhBMI.Name = "btnTinhBMI";
            this.btnTinhBMI.Size = new System.Drawing.Size(101, 23);
            this.btnTinhBMI.TabIndex = 4;
            this.btnTinhBMI.Text = "Tính chỉ sô BMI";
            this.btnTinhBMI.UseVisualStyleBackColor = true;
            this.btnTinhBMI.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // lblChiSo
            // 
            this.lblChiSo.AutoSize = true;
            this.lblChiSo.ForeColor = System.Drawing.Color.Red;
            this.lblChiSo.Location = new System.Drawing.Point(13, 118);
            this.lblChiSo.Name = "lblChiSo";
            this.lblChiSo.Size = new System.Drawing.Size(64, 13);
            this.lblChiSo.TabIndex = 5;
            this.lblChiSo.Text = "Chỉ số BMI: ";
            this.lblChiSo.Click += new System.EventHandler(this.lblChiSo_Click);
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPhanLoai.Location = new System.Drawing.Point(13, 149);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(57, 13);
            this.lblPhanLoai.TabIndex = 6;
            this.lblPhanLoai.Text = "Phân loại: ";
            this.lblPhanLoai.Click += new System.EventHandler(this.lblPhanLoai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 220);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblChiSo);
            this.Controls.Add(this.btnTinhBMI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.txtChieuCao);
            this.Name = "Form1";
            this.Text = "Form Tính Chỉ Số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhBMI;
        private System.Windows.Forms.Label lblChiSo;
        private System.Windows.Forms.Label lblPhanLoai;
    }
}

