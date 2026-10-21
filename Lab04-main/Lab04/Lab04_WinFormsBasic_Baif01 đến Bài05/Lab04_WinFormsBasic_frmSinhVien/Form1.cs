using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic_frmSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form vừa được tải lên (Form Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bài 2: Khởi tạo danh sách Khoa cho ComboBox
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Công nghệ thông tin");
            comboBox1.Items.Add("Công nghệ kỹ thuật ô tô");
            comboBox1.Items.Add("Kinh tế");
            comboBox1.Items.Add("Ngoại ngữ");
            comboBox1.SelectedIndex = 0; // Chọn mặc định khoa đầu tiên

            // Bài 3: Khởi tạo hiển thị tuổi mặc định
            CapNhatTuoi();
        }

        // Bài 3: Hàm tính tuổi từ DateTimePicker
        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi;
        }

        private void CapNhatTuoi()
        {
            int tuoi = TinhTuoi(dtpNgaySinh.Value);
            // Giả sử textBox1 dùng để hiển thị tuổi (hoặc label hiển thị tuổi)
            textBox1.Text = "Tuổi: " + tuoi;
        }

        // Bài 3: Sự kiện khi người dùng thay đổi ngày sinh
        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTuoi();
        }

        // Bài 4: Sự kiện khi nhấn nút "Kiểm tra sở thích"
        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> dsSoThich = new List<string>();

            if (chkDocSach.Checked) dsSoThich.Add("Đọc sách");
            if (chkTheThao.Checked) dsSoThich.Add("Thể thao");
            if (chkLapTrinh.Checked) dsSoThich.Add("Lập trình");

            if (dsSoThich.Count == 0)
            {
                lblSoThich.Text = "Chưa chọn sở thích nào.";
            }
            else
            {
                lblSoThich.Text = "Sở thích: " + string.Join(", ", dsSoThich);
            }
        }

        // Bài 5: Sự kiện chọn ảnh đại diện từ OpenFileDialog
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh đại diện cho sinh viên";
                dlg.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAnh.ImageLocation = dlg.FileName;
                    txtDuongDanAnh.Text = dlg.FileName;
                }
            }
        }

        // Bài 1: Sự kiện nhấn nút "Hiển thị thông tin" xuất MessageBox
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            int tuoi = TinhTuoi(dtpNgaySinh.Value);
            string khoa = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "Chưa chọn";

            string thongTin = $"--- THÔNG TIN SINH VIÊN ---\n\n" +
                              $"Mã SV: {txtMaSV.Text.Trim()}\n" +
                              $"Họ và tên: {txtHoTen.Text.Trim()}\n" +
                              $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy} ({tuoi} tuổi)\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Khoa: {khoa}\n" +
                              $"{lblSoThich.Text}";

            MessageBox.Show(thongTin, "XÁC NHẬN THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Các sự kiện trống giữ nguyên để tránh lỗi Designer
        private void label2_Click(object sender, EventArgs e) { }
        private void txtMaSV_TextChanged(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void radNam_CheckedChanged(object sender, EventArgs e) { }
        private void radNu_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void chkDocSach_CheckedChanged(object sender, EventArgs e) { }
        private void chkLapTrinh_CheckedChanged(object sender, EventArgs e) { }
        private void chkTheThao_CheckedChanged(object sender, EventArgs e) { }
        private void lblSoThich_Click(object sender, EventArgs e) { }
        private void picAnh_Click(object sender, EventArgs e) { }
        private void txtDuongDanAnh_TextChanged(object sender, EventArgs e) { }
    }
}