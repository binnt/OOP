using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TruyenTranh
    {
        public string MaTruyen { get; set; }
        public string TenTruyen { get; set; }
        public string TacGia { get; set; }
        public int SoLuongCon { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma truyen: ");
            MaTruyen = Console.ReadLine();
            Console.Write("Nhap ten truyen: ");
            TenTruyen = Console.ReadLine();
            Console.Write("Nhap tac gia truyen: ");
            TacGia = Console.ReadLine();
            Console.Write("Nhap so luong truyen con: ");
            SoLuongCon = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma truyen: {0}", MaTruyen);
            Console.WriteLine("Ten truyen: {0}", TenTruyen);
            Console.WriteLine("Tac gia truyen: {0}", TacGia);
            Console.WriteLine("So luong truyen con: {0}", SoLuongCon);
        }
    }
}
