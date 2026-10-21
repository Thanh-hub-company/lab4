using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTinhBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Tính BMI"
        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra không để trống dữ liệu
            if (string.IsNullOrWhiteSpace(txtChieuCao.Text) || string.IsNullOrWhiteSpace(txtCanNang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Chiều cao và Cân nặng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra định dạng dữ liệu đầu vào (Phải là số dương)
            if (!double.TryParse(txtChieuCao.Text.Trim(), out double chieuCao) || chieuCao <= 0)
            {
                MessageBox.Show("Chiều cao không hợp lệ! Vui lòng nhập số lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
                return;
            }

            if (!double.TryParse(txtCanNang.Text.Trim(), out double canNang) || canNang <= 0)
            {
                MessageBox.Show("Cân nặng không hợp lệ! Vui lòng nhập số lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
                return;
            }

            // 3. Tự động chuyển đổi nếu người dùng nhập chiều cao dạng cm (Ví dụ: 170cm -> 1.7m)
            if (chieuCao > 3)
            {
                chieuCao /= 100.0;
            }

            // 4. Tính chỉ số BMI = Cân nặng / (Chiều cao ^ 2)
            double bmi = canNang / (chieuCao * chieuCao);

            // 5. Đánh giá phân loại thể trạng theo chỉ số BMI
            string phanLoai = "";
            Color mauThongBao = Color.Black;

            if (bmi < 18.5)
            {
                phanLoai = "Gầy (Thiếu cân)";
                mauThongBao = Color.Orange;
            }
            else if (bmi < 24.9)
            {
                phanLoai = "Bình thường (Lý tưởng)";
                mauThongBao = Color.DarkGreen;
            }
            else if (bmi < 29.9)
            {
                phanLoai = "Thừa cân";
                mauThongBao = Color.DarkOrange;
            }
            else
            {
                phanLoai = "Béo phì";
                mauThongBao = Color.Red;
            }

            // 6. Hiển thị kết quả lên giao diện
            lblChiSo.Text = $"Chỉ số BMI: {bmi:N2}";
            lblPhanLoai.Text = $"Phân loại: {phanLoai}";
            lblPhanLoai.ForeColor = mauThongBao;
        }

        // Giữ lại các sự kiện rỗng để tránh vỡ giao diện Designer
        private void txtChieuCao_TextChanged(object sender, EventArgs e) { }
        private void txtCanNang_TextChanged(object sender, EventArgs e) { }
        private void lblChiSo_Click(object sender, EventArgs e) { }
        private void lblPhanLoai_Click(object sender, EventArgs e) { }
    }
}