using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TruyenThieuNhi : TruyenTranh
    {
        public int DoTuoi { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap do tuoi truyen: ");
            DoTuoi = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Do Tuoi: {0}", DoTuoi);
        }
    }
}
