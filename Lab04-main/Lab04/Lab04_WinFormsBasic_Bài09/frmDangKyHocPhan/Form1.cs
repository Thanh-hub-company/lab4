using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangKyHocPhan
{
    public partial class Form1 : Form
    {
        // Class mô tả thông tin Học phần
        public class HocPhan
        {
            public string TenHocPhan { get; set; }
            public int SoTinChi { get; set; }

            public HocPhan(string tenHocPhan, int soTinChi)
            {
                TenHocPhan = tenHocPhan;
                SoTinChi = soTinChi;
            }

            public override string ToString()
            {
                return $"{TenHocPhan} ({SoTinChi} Tín chỉ)";
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Khởi tạo danh sách ngay trong Constructor để đảm bảo môn học luôn hiển thị
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            // Tự động thêm danh sách môn học nếu CheckedListBox chưa có dữ liệu
            if (chklbHocPhan.Items.Count == 0)
            {
                chklbHocPhan.Items.Add(new HocPhan("Lập trình .NET", 3));
                chklbHocPhan.Items.Add(new HocPhan("Cơ sở dữ liệu", 3));
                chklbHocPhan.Items.Add(new HocPhan("Cấu trúc dữ liệu & Giải thuật", 4));
                chklbHocPhan.Items.Add(new HocPhan("Mạng máy tính", 3));
                chklbHocPhan.Items.Add(new HocPhan("Tiếng Anh chuyên ngành", 2));
            }

            // Bật chế độ chọn/tích ngay khi click chuột
            chklbHocPhan.CheckOnClick = true;

            // Đăng ký sự kiện thay đổi tích chọn để tự động cập nhật số tín chỉ
            chklbHocPhan.ItemCheck += ChklbHocPhan_ItemCheck;

            CapNhatTongTinChi();
        }

        // Tự động cập nhật tổng tín chỉ ngay khi tích/bỏ tích chọn môn học
        private void ChklbHocPhan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                CapNhatTongTinChi();
            });
        }

        // Hàm tính tổng số tín chỉ
        private void CapNhatTongTinChi()
        {
            int tongTinChi = 0;

            foreach (var item in chklbHocPhan.CheckedItems)
            {
                if (item is HocPhan hp)
                {
                    tongTinChi += hp.SoTinChi;
                }
                else
                {
                    // Tự động bóc tách số tín chỉ nếu nhập văn bản trực tiếp từ Designer
                    Match match = Regex.Match(item.ToString(), @"(\d+)\s*(Tín chỉ|TC|tc)", RegexOptions.IgnoreCase);
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int tc))
                    {
                        tongTinChi += tc;
                    }
                }
            }

            lblTongTinChi.Text = $"Tổng kết: {tongTinChi} tín chỉ";
        }

        // Sự kiện khi nhấn nút "Xác nhận" (btnDangKy)
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (chklbHocPhan.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 học phần để đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== DANH SÁCH HỌC PHẦN ĐÃ ĐĂNG KÝ ===");
            sb.AppendLine();

            int stt = 1;
            foreach (var item in chklbHocPhan.CheckedItems)
            {
                sb.AppendLine($"{stt++}. {item}");
            }

            sb.AppendLine();
            sb.AppendLine(lblTongTinChi.Text);

            MessageBox.Show(sb.ToString(), "XÁC NHẬN ĐĂNG KÝ HỌC PHẦN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Giữ lại các hàm sự kiện rỗng để tránh vỡ giao diện Designer
        private void chklbHocPhan_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblTongTinChi_Click(object sender, EventArgs e) { }
    }
}