# HƯỚNG DẪN CHẠY DỰ ÁN LAB 04 - WINFORMS CƠ BẢN (C# / .NET FRAMEWORK)

Dự án **Lab 04: Windows Forms Basic** gồm các bài thực hành xây dựng giao diện ứng dụng desktop bằng **C#** trên nền tảng **.NET Framework 4.7.2** (Windows Forms Application).

---

## 1. YÊU CẦU HỆ THỐNG & PHẦN MỀM CẦN THIẾT

- **Hệ điều hành:** Windows 10 / Windows 11.
- **Môi trường phát triển (khuyến nghị):**
  - **Visual Studio 2022** (hỗ trợ đọc định dạng Solution `.slnx`).
  - Workload cần cài đặt: **.NET desktop development** (Phát triển ứng dụng trên máy tính bằng .NET).
- **.NET Framework:** Phiên bản **.NET Framework 4.7.2 Runtime / Developer Pack** trở lên.

---

## 2. CẤU TRÚC DỰ ÁN

Thư mục bài tập được chia thành các project độc lập theo từng bài:

| STT | Thư mục bài tập | Tên Project / Solution | Mô tả chức năng |
|:---:|:---|:---|:---|
| **01-05** | `Lab04_WinFormsBasic_Baif01 đến Bài05` | `Lab04_WinFormsBasic_frmSinhVien` | Quản lý thông tin sinh viên, tính tuổi tự động từ ngày sinh, chọn khoa, giới tính, quê quán. |
| **06** | `Lab04_WinFormsBasic_BÀI06` | `frmMayTinh` | Ứng dụng máy tính cầm tay thực hiện các phép toán cơ bản (+, -, *, /). |
| **07** | `Lab04_WinFormsBasic_Bài07` | `frmDangNhap` | Form đăng nhập hệ thống, hiển thị/ẩn mật khẩu, tài khoản demo: `admin` / `123456`. |
| **08** | `Lab04_WinFormsBasic_Bài08` | `frmTinhBMI` | Tính toán chỉ số khối cơ thể (BMI) từ chiều cao/cân nặng và đưa ra phân loại thể trạng. |
| **09** | `Lab04_WinFormsBasic_Bài09` | `frmDangKyHocPhan` | Form đăng ký học phần sinh viên, tính tổng số tín chỉ và học phí. |
| **10** | `Lab04_WinFormsBasic_Bài10` | `frmPhieuNhapSanPham` | Quản lý phiếu nhập sản phẩm, tính tiền, chọn ảnh minh họa và hiển thị bảng dữ liệu. |
| **Ảnh** | `Ảnh chụp kết quả` | - | Chứa toàn bộ ảnh chụp giao diện và kết quả thực thi của các bài. |

---

## 3. CÁCH CHẠY DỰ ÁN

Bạn có thể chạy dự án bằng một trong các cách sau:

### Cách 1: Chạy trực tiếp file thực thi (.exe đã biên dịch sẵn) - Nhanh nhất
Dự án đã được biên dịch sẵn trong thư mục `bin\Debug` của mỗi bài. Bạn chỉ cần điều hướng đến thư mục tương ứng và nháy đúp chuột vào file `.exe`:

- **Bài 01 - 05:**
  `.\Lab04_WinFormsBasic_Baif01 đến Bài05\Lab04_WinFormsBasic_frmSinhVien\bin\Debug\Lab04_WinFormsBasic_frmSinhVien.exe`
- **Bài 06:**
  `.\Lab04_WinFormsBasic_BÀI06\frmMayTinh\bin\Debug\frmMayTinh.exe`
- **Bài 07:**
  `.\Lab04_WinFormsBasic_Bài07\frmDangNhap\bin\Debug\frmDangNhap.exe`
- **Bài 08:**
  `.\Lab04_WinFormsBasic_Bài08\frmTinhBMI\bin\Debug\frmTinhBMI.exe`
- **Bài 09:**
  `.\Lab04_WinFormsBasic_Bài09\frmDangKyHocPhan\bin\Debug\frmDangKyHocPhan.exe`
- **Bài 10:**
  `.\Lab04_WinFormsBasic_Bài10\frmPhieuNhapSanPham\bin\Debug\frmPhieuNhapSanPham.exe`

---

### Cách 2: Mở và chạy bằng Visual Studio 2022 (Khuyến nghị cho lập trình & chấm điểm)

1. Mở thư mục bài cần chạy (ví dụ `Lab04_WinFormsBasic_Bài07`).
2. Mở file Solution `.slnx` (hoặc mở file dự án `.csproj` trong thư mục con tương ứng):
   - Ví dụ Bài 07: Nhấp đúp vào `Lab04_WinFormsBasic_Bài07.slnx` hoặc `frmDangNhap\frmDangNhap.csproj`.
3. Trong giao diện Visual Studio:
   - Chọn cấu hình biên dịch: **Debug** hoặc **Release**, nền tảng **Any CPU**.
   - Nhấn phím **F5** (hoặc nút **Start / ▶ Start Debugging**) để biên dịch và chạy.
   - Hoặc nhấn **Ctrl + F5** (Start Without Debugging) để chạy trực tiếp không qua debug.

---

### Cách 3: Biên dịch và chạy bằng dòng lệnh (PowerShell / Command Prompt)

Nếu máy tính của bạn đã cấu hình môi trường MSBuild của Visual Studio:

1. Mở **Developer PowerShell for VS 2022** (hoặc Developer Command Prompt).
2. Điều hướng tới thư mục chứa project `.csproj` cần build, ví dụ Bài 06:
   ```powershell
   cd "d:\BT Classroom Lab\Lab04\Lab04_WinFormsBasic_BÀI06\frmMayTinh"
   ```
3. Chạy lệnh build:
   ```powershell
   msbuild /p:Configuration=Debug
   ```
4. Khởi chạy ứng dụng:
   ```powershell
   .\bin\Debug\frmMayTinh.exe
   ```

---

## 4. GHI CHÚ VÀ TÀI KHOẢN MẪU (TEST DATA)

- **Bài 07 (Đăng nhập):**
  - **Tên đăng nhập:** `admin`
  - **Mật khẩu:** `123456`
  - Có tính năng checkbox: *Hiển thị mật khẩu* và *Ghi nhớ thông tin đăng nhập*.
- **Bài 08 (Tính BMI):**
  - Nhập **Chiều cao (m)** (ví dụ: `1.70`) và **Cân nặng (kg)** (ví dụ: `65`).
- **Hình ảnh kết quả:**
  - Mọi kết quả chạy thử nghiệm đã được lưu đầy đủ trong thư mục `Ảnh chụp kết quả/`.

