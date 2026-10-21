using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi tích/bỏ tích checkbox "Hiển thị mật khẩu"
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu chọn CheckBox -> hiển thị mật khẩu dạng văn bản thường ('\0')
            // Nếu bỏ chọn -> ẩn mật khẩu bằng ký tự '*'
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '*';
        }

        // Sự kiện khi nhấn nút "Đăng nhập"
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // 1. Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Xác thực tài khoản mẫu (Tài khoản: admin / Mật khẩu: 123456)
            if (tenDangNhap == "admin" && matKhau == "123456")
            {
                string thongBao = "Đăng nhập hệ thống thành công!";
                if (chkGhiNho.Checked)
                {
                    thongBao += "\n(Đã ghi nhớ thông tin đăng nhập)";
                }

                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        // Sự kiện khi nhấn nút "Hủy"
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy thao tác và thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Sự kiện lưu giữ ghi nhớ phiên đăng nhập
        private void chkGhiNho_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý tùy chọn lưu thông tin khi được kích hoạt
        }

        // Giữ lại các phương thức sự kiện Designer liên kết để tránh lỗi CS1061
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void txtMatKhau_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e) { }
    }
}