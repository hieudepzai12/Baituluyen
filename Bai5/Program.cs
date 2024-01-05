using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanlyCD quanlyCD = new QuanlyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("**********Chuong trinh quan ly CD*********");
                Console.WriteLine("1. Them CD.\n2. Tinh gia thanh trung binh.\n3. Sap xep CD giam dan them gia thanh.\n4. Sap xep CD tang dan theo tua CD.\n5. Xuat toan bo CD.\n0. Thoat chuong trinh.");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD:");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ten ca si:");
                        cd.CaSi = Console.ReadLine();
                        Console.Write("Nhap so bai hat da hat:");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia tien:");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanlyCD.ThemCD(cd);
                        break;

                    case 2:
                        double kq = quanlyCD.TinhGiaTB();
                        Console.WriteLine("Gia tien trung binh: {0:#,##0.00}", kq);
                        break;

                    case 3:
                        quanlyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap them theo gia tien giam dan!");
                        break;

                    case 4:
                        quanlyCD.SapXepTangTheoTuaCD();
                        Console.WriteLine("Da sap xep theo tua CD!");
                        break;

                    case 5:
                        quanlyCD.XuatGiaTri();
                        break;

                    case 0:
                        Console.WriteLine("Goodbye! Don't see you again!");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
        }
    }
}
        
