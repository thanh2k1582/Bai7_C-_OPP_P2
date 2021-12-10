using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLGV quanLyGiaoVien = new QLGV();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY GIAO VIEN");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them giao vien.                               **");
                Console.WriteLine("**  2. Tim va xoa giang vien heo MSGV.               **");
                Console.WriteLine("**  3. Hien thi danh sach giang vien.                **");
                Console.WriteLine("**  4. Tinh luong thuc linh.                         **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        quanLyGiaoVien.NhapGv();
                        Console.WriteLine("\nThem thong tin giao vien thanh cong!");
                        break;
                    case 2:
                        Console.Write("\nNhap so CMND muon xoa: ");
                        string name2 = Convert.ToString(Console.ReadLine());
                        if (quanLyGiaoVien.DeleteByMSGV(name2))
                        {
                            Console.WriteLine("\nThong tin giao vien hang da bi xoa!.", name2);
                        }
                        break;

                    case 3:
                        quanLyGiaoVien.XuatGv(quanLyGiaoVien.getListGiaoVien());
                        break;
                    case 4:
                        Console.Write("\nNhap MSGV de tinh luong thuc linh cua nguoi do: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<Nguoi> searchResult1 = quanLyGiaoVien.timTheoMSGV(name);
                        Console.Write("Nhap luong cung: ");
                        int luongCung = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap luong thuong: ");
                        int luongThuong = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap tien bi phat: ");
                        int luongPhat = Int32.Parse(Console.ReadLine());
                        quanLyGiaoVien.XuatGv(searchResult1);
                        Console.Write("Luong thuc linh cua giao vien co ma {0} la: {1}",name,luongCung+luongThuong-luongPhat);
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
