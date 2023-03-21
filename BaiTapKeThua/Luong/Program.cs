public class Luong
{
    private string hoTen;
    private double luongCoBan;
    private double heSoLuong;

    public Luong(double luongCoBan = 450, double heSoLuong = 2.3)
    {
        this.luongCoBan = luongCoBan;
        this.heSoLuong = heSoLuong;
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value; }
    }

    public double HeSoLuong
    {
        get { return heSoLuong; }
        set { heSoLuong = value; }
    }

    public double TinhLuong()
    {
        return luongCoBan * heSoLuong;
    }
}

public class CanBo : Luong
{
    private double heSoPhuCap;

    public CanBo(double luongCoBan = 450, double heSoLuong = 2.3, double heSoPhuCap = 1.0) : base(luongCoBan, heSoLuong)
    {
        this.heSoPhuCap = heSoPhuCap;
    }

    public double HeSoPhuCap
    {
        get { return heSoPhuCap; }
        set { heSoPhuCap = value; }
    }

    public double TinhLuongMoi()
    {
        return LuongCoBan * HeSoLuong * heSoPhuCap;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap ho ten cua can bo: ");
        string hoTen = Console.ReadLine();

        Console.WriteLine("Nhap luong co ban: ");
        double luongCoBan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap he so luong: ");
        double heSoLuong = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap he so phu cap: ");
        double heSoPhuCap = double.Parse(Console.ReadLine());

        CanBo canBo = new CanBo(luongCoBan, heSoLuong, heSoPhuCap);
        canBo.HoTen = hoTen;

        Console.WriteLine("Thong tin can bo:");
        Console.WriteLine("Ho ten: " + canBo.HoTen);
        Console.WriteLine("Luong co ban: " + canBo.LuongCoBan);
        Console.WriteLine("He so luong: " + canBo.HeSoLuong);
        Console.WriteLine("He so phu cap: " + canBo.HeSoPhuCap);
        Console.WriteLine("Luong moi: " + canBo.TinhLuongMoi());
    }
}
