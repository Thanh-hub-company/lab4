================================================================================
HƯỚNG DẪN CHẠY DỰ ÁN LAB 04 - WINFORMS CƠ BẢN (C# / .NET FRAMEWORK)
================================================================================

Dự án Lab 04 gồm các bài thực hành lập trình giao diện Desktop bằng C# 
trên nền tảng .NET Framework 4.7.2 (Windows Forms Application).

--------------------------------------------------------------------------------
1. YÊU CẦU HỆ THỐNG & PHẦN MỀM
--------------------------------------------------------------------------------
- Hệ điều hành: Windows 10 / Windows 11.
- Môi trường phát triển khuyến nghị: 
  + Visual Studio 2022 (hỗ trợ định dạng file Solution mới .slnx).
  + Đã cài đặt Workload: ".NET desktop development".
- .NET Framework: Phiên bản .NET Framework 4.7.2 trở lên.

--------------------------------------------------------------------------------
2. CẤU TRÚC CÁC BÀI TẬP TRONG DỰ ÁN
--------------------------------------------------------------------------------
- Bài 01 đến Bài 05:
  + Thư mục: .\Lab04_WinFormsBasic_Baif01 đến Bài05
  + Project: Lab04_WinFormsBasic_frmSinhVien
  + Mô tả: Quản lý thông tin sinh viên, tính tuổi tự động từ ngày sinh, 
           lựa chọn khoa, giới tính, quê quán.

- Bài 06:
  + Thư mục: .\Lab04_WinFormsBasic_BÀI06
  + Project: frmMayTinh
  + Mô tả: Máy tính cầm tay mini thực hiện các phép tính cơ bản (+, -, *, /).

- Bài 07:
  + Thư mục: .\Lab04_WinFormsBasic_Bài07
  + Project: frmDangNhap
  + Mô tả: Form đăng nhập hệ thống, hiển thị/ẩn mật khẩu.
  + Tài khoản mẫu: Tên đăng nhập: admin | Mật khẩu: 123456

- Bài 08:
  + Thư mục: .\Lab04_WinFormsBasic_Bài08
  + Project: frmTinhBMI
  + Mô tả: Tính chỉ số khối cơ thể (BMI) từ chiều cao (m) và cân nặng (kg),
           đưa ra đánh giá phân loại thể trạng.

- Bài 09:
  + Thư mục: .\Lab04_WinFormsBasic_Bài09
  + Project: frmDangKyHocPhan
  + Mô tả: Đăng ký môn học/học phần, tính tổng tín chỉ và học phí tương ứng.

- Bài 10:
  + Thư mục: .\Lab04_WinFormsBasic_Bài10
  + Project: frmPhieuNhapSanPham
  + Mô tả: Quản lý phiếu nhập sản phẩm, tính tiền, chọn ảnh sản phẩm,
           hiển thị danh sách sản phẩm đã nhập.

- Thư mục ảnh kết quả:
  + .\Ảnh chụp kết quả: Chứa toàn bộ hình ảnh giao diện chạy thực tế của các bài.

--------------------------------------------------------------------------------
3. CÁCH CHẠY DỰ ÁN
--------------------------------------------------------------------------------

CÁCH 1: CHẠY TRỰC TIẾP FILE .EXE ĐÃ BUILD SẴN (NHANH NHẤT)
-------------------------------------------------------------------
Tất cả các bài đã được biên dịch sẵn file thực thi trong thư mục bin\Debug.
Bạn chỉ cần nhấp đúp chuột để mở trực tiếp:

- Bài 01-05:
  .\Lab04_WinFormsBasic_Baif01 đến Bài05\Lab04_WinFormsBasic_frmSinhVien\bin\Debug\Lab04_WinFormsBasic_frmSinhVien.exe
- Bài 06:
  .\Lab04_WinFormsBasic_BÀI06\frmMayTinh\bin\Debug\frmMayTinh.exe
- Bài 07:
  .\Lab04_WinFormsBasic_Bài07\frmDangNhap\bin\Debug\frmDangNhap.exe
- Bài 08:
  .\Lab04_WinFormsBasic_Bài08\frmTinhBMI\bin\Debug\frmTinhBMI.exe
- Bài 09:
  .\Lab04_WinFormsBasic_Bài09\frmDangKyHocPhan\bin\Debug\frmDangKyHocPhan.exe
- Bài 10:
  .\Lab04_WinFormsBasic_Bài10\frmPhieuNhapSanPham\bin\Debug\frmPhieuNhapSanPham.exe


CÁCH 2: MỞ BẰNG VISUAL STUDIO 2022 (KHUYẾN NGHỊ CHO LẬP TRÌNH & CHẤM ĐIỂM)
-------------------------------------------------------------------
1. Mở Visual Studio 2022.
2. Vào thư mục bài cần chạy, mở file Solution (.slnx) hoặc file Project (.csproj).
   Ví dụ:
   - Bài 07: Mở file .\Lab04_WinFormsBasic_Bài07\Lab04_WinFormsBasic_Bài07.slnx
   - Hoặc mở trực tiếp file .\Lab04_WinFormsBasic_Bài07\frmDangNhap\frmDangNhap.csproj
3. Nhấn phím F5 (hoặc bấm nút "Start" màu xanh) để biên dịch và chạy ứng dụng.
4. Có thể nhấn tổ hợp phím Ctrl + F5 để chạy mà không cần chế độ Debug.


CÁCH 3: BIÊN DỊCH VÀ CHẠY BẰNG DÒNG LỆNH (DEVELOPER POWERSHELL / CMD)
-------------------------------------------------------------------
1. Khởi động "Developer PowerShell for VS 2022".
2. Di chuyển đến thư mục chứa file .csproj của bài cần build:
   cd "d:\BT Classroom Lab\Lab04\Lab04_WinFormsBasic_BÀI06\frmMayTinh"
3. Biên dịch bằng MSBuild:
   msbuild /p:Configuration=Debug
4. Chạy file exe vừa build:
   .\bin\Debug\frmMayTinh.exe

================================================================================

