using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TruyenTieuThuyet : TruyenTranh
    {
        public string LoaiTieuThuyet { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap loai tieu thuyet: ");
            LoaiTieuThuyet = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Loai tieu thuyet: {0}", LoaiTieuThuyet);
        }
    }
}
