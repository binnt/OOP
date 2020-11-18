using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TruyenTranh> dsTruyenTranh = new List<TruyenTranh>();
            int n;
            Console.Write("Nhap so luong truyen: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin truyen thu {0}: ", i);
                TruyenTranh truyen = null;

                Console.WriteLine("Nhap 0 - Thieu nhi, 1 - Tieu thuyent, con lai la Hanh Dong");
                int loai = Convert.ToInt32(Console.ReadLine());

                if (loai == 0)
                    truyen = new TruyenThieuNhi();
                else if (loai == 1)
                    truyen = new TruyenTieuThuyet();
                else
                    truyen = new TruyenHanhDong();


                //Add truyen vao danh sach truyen
                dsTruyenTranh.Add(truyen);
                truyen.Nhap();
            }

            foreach (var quyenTruyen in dsTruyenTranh)
            {
                quyenTruyen.Xuat();
            }

            //Xuat thong tin
            for (int i = 0; i < dsTruyenTranh.Count; i++)
            {
                if (i == 0 || i == 2 || i == 5)
                    dsTruyenTranh.ElementAt(i).Xuat();
            }

            //Chen them
            dsTruyenTranh.Insert(2, new TruyenThieuNhi());
            dsTruyenTranh[2].Nhap();
            dsTruyenTranh.Insert(3, new TruyenThieuNhi());
            dsTruyenTranh[3].Nhap();

        }
    }
}
