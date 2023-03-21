class Nhanvien
{
    private string hoten;
    private int tuoi;
    private float hesoluong;
    private float luongcoban
    public Nhanvien(string ht, int t, float hsl, float luongcb)
    {
        hoten = ht;
        tuoi = t;
        hesoluong = hsl;
        luongcoban = luongcb;
    }
    public double tinhluong()
    {
        return hesoluong * luongcoban;
    }
    public virtual double tinhluong(int phucap)
    {
        return hesoluong * luongcoban + (hesoluong * luongcoban * phucap)/100;
    }
    public virtual void Show()
    {
        Console.WriteLine("Ho ten: {0}\ntuoi: {1} \nHe so luong: {2}\nLuong co ban {3} " )
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ")
    }
}