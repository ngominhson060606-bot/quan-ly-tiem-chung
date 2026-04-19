using System;
using System.Collections.Generic;

class NguoiDan
{
    public string Ten;
    public int NamSinh;

    public void Nhap()
    {
        Console.Write("Nhap ten: ");
        Ten = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        Console.WriteLine("Ten: " + Ten + " | Nam sinh: " + NamSinh);
    }
}

class Program
{
    static List<NguoiDan> ds = new List<NguoiDan>();

    static void Main()
    {
        int chon;
        do
        {
            Console.WriteLine("\n===== HE THONG TIEM CHUNG =====");
            Console.WriteLine("1. Them nguoi");
            Console.WriteLine("2. Hien danh sach");
            Console.WriteLine("3. Tim kiem");
            Console.WriteLine("4. Xoa");
            Console.WriteLine("0. Thoat");

            Console.Write("Chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Them();
                    break;
                case 2:
                    Hien();
                    break;
                case 3:
                    Tim();
                    break;
                case 4:
                    Xoa();
                    break;
            }

        } while (chon != 0);
    }

    static void Them()
    {
        NguoiDan n = new NguoiDan();
        n.Nhap();
        ds.Add(n);
        Console.WriteLine("Them thanh cong!");
    }

    static void Hien()
    {
        Console.WriteLine("\nDanh sach:");
        foreach (var n in ds)
            n.HienThi();
    }

    static void Tim()
    {
        Console.Write("Nhap ten can tim: ");
        string ten = Console.ReadLine();

        foreach (var n in ds)
            if (n.Ten.ToLower().Contains(ten.ToLower()))
                n.HienThi();
    }

    static void Xoa()
    {
        Console.Write("Nhap ten can xoa: ");
        string ten = Console.ReadLine();

        ds.RemoveAll(n => n.Ten.ToLower() == ten.ToLower());
        Console.WriteLine("Da xoa!");
    }
}