using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPhieuNhapSanPham
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = "";

        public Form1()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        // Khởi tạo các giá trị mặc định cho Form
        private void KhoiTaoDuLieu()
        {
            // Nạp danh sách Loại sản phẩm vào ComboBox nếu chưa có
            if (cboLoaiSP.Items.Count == 0)
            {
                cboLoaiSP.Items.Add("Laptop");
                cboLoaiSP.Items.Add("Điện thoại");
                cboLoaiSP.Items.Add("Linh kiện máy tính");
                cboLoaiSP.Items.Add("Thiết bị văn phòng");
                cboLoaiSP.SelectedIndex = 0;
            }

            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpNgayNhap.Value = DateTime.Now;
            picAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Sự kiện nhấn nút "Chọn ảnh SP..."
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh sản phẩm";
                dlg.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = dlg.FileName;
                    picAnhSP.ImageLocation = duongDanAnh;
                }
            }
        }

        // Sự kiện nhấn nút "Lưu phiếu nhập"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập liệu Mã và Tên sản phẩm
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }

            // 2. Kiểm tra Đơn giá
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return;
            }

            // 3. Tính toán Thành tiền
            int soLuong = (int)nudSoLuong.Value;
            decimal thanhTien = soLuong * donGia;
            string loaiSP = cboLoaiSP.SelectedItem != null ? cboLoaiSP.SelectedItem.ToString() : "Chưa chọn";

            // 4. Tổng hợp thông tin phiếu nhập
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PHIẾU NHẬP SẢN PHẨM THÀNH CÔNG ===");
            sb.AppendLine();
            sb.AppendLine($"Mã SP: {txtMaSP.Text.Trim()}");
            sb.AppendLine($"Tên SP: {txtTenSP.Text.Trim()}");
            sb.AppendLine($"Loại SP: {loaiSP}");
            sb.AppendLine($"Số lượng: {soLuong}");
            sb.AppendLine($"Đơn giá: {donGia:N0} VNĐ");
            sb.AppendLine($"Thành tiền: {thanhTien:N0} VNĐ");
            sb.AppendLine($"Ngày nhập: {dtpNgayNhap.Value:dd/MM/yyyy}");
            sb.AppendLine($"Ảnh đính kèm: {(string.IsNullOrEmpty(duongDanAnh) ? "Chưa chọn ảnh" : duongDanAnh)}");

            MessageBox.Show(sb.ToString(), "XÁC NHẬN LƯU PHIẾU NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Giữ nguyên các phương thức sự kiện Designer liên kết để tránh lỗi CS1061 / CS0103
        private void txtMaSP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void txtTenSP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nudSoLuong_ValueChanged(object sender, EventArgs e) { }
        private void txtDonGia_TextChanged(object sender, EventArgs e) { }
        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e) { }
        private void picAnhSP_Click(object sender, EventArgs e) { }
    }
}