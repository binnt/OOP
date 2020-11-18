using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TruyenHanhDong : TruyenTranh
    {
        public int MucDo { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc do: ");
            MucDo = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Muc do: {0}", MucDo);
        }
    }
}
