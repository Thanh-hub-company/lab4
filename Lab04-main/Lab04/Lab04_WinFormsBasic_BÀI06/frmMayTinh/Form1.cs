using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm dùng chung để thực hiện tính toán và kiểm tra dữ liệu
        private void TinhPhepToan(char phepToan)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số thứ nhất và Số thứ hai!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSo1.Text.Trim(), out double a) || !double.TryParse(txtSo2.Text.Trim(), out double b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double kq = 0;
            switch (phepToan)
            {
                case '+':
                    kq = a + b;
                    break;
                case '-':
                    kq = a - b;
                    break;
                case '*':
                    kq = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("Không thể thực hiện phép chia cho 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtKetQua.Clear();
                        return;
                    }
                    kq = a / b;
                    break;
            }

            // Hiển thị kết quả làm tròn 2 chữ số thập phân
            txtKetQua.Text = kq.ToString("N2");
        }

        // Cộng (button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            TinhPhepToan('+');
        }

        // Trừ (button2_Click)
        private void button2_Click(object sender, EventArgs e)
        {
            TinhPhepToan('-');
        }

        // Nhân (btnNhan_Click)
        private void btnNhan_Click(object sender, EventArgs e)
        {
            TinhPhepToan('*');
        }

        // Chia (btnChia_Click)
        private void btnChia_Click(object sender, EventArgs e)
        {
            TinhPhepToan('/');
        }

        // Nút Làm mới: Xóa trắng toàn bộ ô nhập liệu và đưa con trỏ về ô Số 1
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            txtSo1.Focus();
        }

        // Nút Thoát: Xác nhận đóng Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Các sự kiện thay đổi dữ liệu hoặc click label giữ nguyên
        private void label2_Click(object sender, EventArgs e) { }
        private void txtSo1_TextChanged(object sender, EventArgs e) { }
        private void txtSo2_TextChanged(object sender, EventArgs e) { }
        private void txtKetQua_TextChanged(object sender, EventArgs e) { }
    }
}