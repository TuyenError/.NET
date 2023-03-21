// Lớp mô tả thông tin của một nhân viên
public class NhanVien
{
    public string HoTen { get; set; } // Họ tên nhân viên
    public DateTime NgaySinh { get; set; } // Ngày sinh nhân viên
    public string DiaChi { get; set; } // Địa chỉ nhân viên

    // Hàm khởi tạo lớp NhanVien
    public NhanVien(string hoTen, DateTime ngaySinh, string diaChi)
    {
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        DiaChi = diaChi;
    }

    // Phương thức tính lương - phải được định nghĩa lại trong các lớp con
    public virtual double TinhLuong()
    {
        return 0; // Trả về 0 nếu không định nghĩa lại trong lớp con
    }
}

// Lớp mô tả thông tin của một nhân viên sản xuất
public class NhanVienSanXuat : NhanVien
{
    public int SoSanPham { get; set; } // Số sản phẩm mà nhân viên sản xuất được trong tháng

    // Hàm khởi tạo lớp NhanVienSanXuat
    public NhanVienSanXuat(string hoTen, DateTime ngaySinh, string diaChi, int soSanPham)
    : base(hoTen, ngaySinh, diaChi)
    {
        SoSanPham = soSanPham;
    }

    // Định nghĩa lại phương thức tính lương cho nhân viên sản xuất
    public override double TinhLuong()
    {
        return SoSanPham * 20000;
    }
}

// Lớp mô tả thông tin của một nhân viên công nhật
public class NhanVienCongNhat : NhanVien
{
    public int SoNgayCong { get; set; } // Số ngày công của nhân viên công nhật trong tháng

    // Hàm khởi tạo lớp NhanVienCongNhat
    public NhanVienCongNhat(string hoTen, DateTime ngaySinh, string diaChi, int soNgayCong)
    : base(hoTen, ngaySinh, diaChi)
    {
        SoNgayCong = soNgayCong;
    }

    // Định nghĩa lại phương thức tính lương cho nhân viên công nhật
    public override double TinhLuong()
    {
        return SoNgayCong * 50000;
    }
}

// Lớp mô tả thông tin của một nhân viên quản lý
public class NhanVienQuanLy : NhanVien
{
    public double HeSoLuong { get; set; } // Hệ số lương của nhân viên quản lý
    public double LuongCoBan { get; set; } // Lương cơ bản của nhân viên quản lý
                                           // Hàm khởi tạo lớp NhanVienQuanLy
    public NhanVienQuanLy(string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan)
        : base(hoTen, ngaySinh, diaChi)
    {
        HeSoLuong = heSoLuong;
        LuongCoBan = luongCoBan;
    }

    // Định nghĩa lại phương thức tính lương cho nhân viên quản lý
    public override double TinhLuong()
    {
        return HeSoLuong * LuongCoBan;
    }
}

// Chương trình chính để kiểm tra các lớp và tính lương cho nhân viên
public class Program
{
    public static void Main()
    {
        // Khởi tạo các đối tượng nhân viên
        var nhanVienSanXuat = new NhanVienSanXuat("Cao Tuyen", new DateTime(2002, 1, 16), "Khanhoa", 100);
        var nhanVienCongNhat = new NhanVienCongNhat("Pham Quy Hien", new DateTime(1995, 2, 1), "Ho Chi Minh City", 20);
        var nhanVienQuanLy = new NhanVienQuanLy("Thư Anh Nguyen", new DateTime(1985, 3, 1), "Da Nang", 1.5, 20000000);
        // In thông tin nhân viên
        Console.WriteLine("Thong tin nhan vien san xuat: ");
        Console.WriteLine($"Ho ten: {nhanVienSanXuat.HoTen}");
        Console.WriteLine($"Ngay sinh: {nhanVienSanXuat.NgaySinh.ToShortDateString()}");
        Console.WriteLine($"Dia chi: {nhanVienSanXuat.DiaChi}");
        Console.WriteLine($"So san pham: {nhanVienSanXuat.SoSanPham}");
        Console.WriteLine($"Luong: {nhanVienSanXuat.TinhLuong():0,0} VND"); 

        Console.WriteLine("Thong tin nhan vien cong nhat: ");
        Console.WriteLine($"Ho ten: {nhanVienCongNhat.HoTen}");
        Console.WriteLine($"Ngay sinh: {nhanVienCongNhat.NgaySinh.ToShortDateString()}");
        Console.WriteLine($"Dia chi: {nhanVienCongNhat.DiaChi}");
        Console.WriteLine($"So ngay cong: {nhanVienCongNhat.SoNgayCong}");
        Console.WriteLine($"Luong: {nhanVienCongNhat.TinhLuong():0,0} VND");

        Console.WriteLine("Thong tin nhan vien quan ly: ");
        Console.WriteLine($"Ho ten: {nhanVienQuanLy.HoTen}");
        Console.WriteLine($"Ngay sinh: {nhanVienQuanLy.NgaySinh.ToShortDateString()}");
        Console.WriteLine($"Dia chi: {nhanVienQuanLy.DiaChi}");
        Console.WriteLine($"He so luong: {nhanVienQuanLy.HeSoLuong}");
        Console.WriteLine($"Luong co ban: {nhanVienQuanLy.LuongCoBan:0,0} VND");
        Console.WriteLine($"Luong: {nhanVienQuanLy.TinhLuong():0,0} VND");
        // Tạm dừng chương trình để người dùng có thể xem kết quả
        Console.ReadLine();
    }
}