using HinhHoc.Model;
using System;

namespace HinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HinhVuong hv = new HinhVuong()
            {
                canh = 4
            };
            HinhVuong hv1 = new HinhVuong();
            hv1.canh = 10;
            Console.WriteLine(hv.DienTich());
            Console.WriteLine(hv.ChuVi());

            HinhChuNhat hcn = new HinhChuNhat();
            hcn.canhA = 4;
            hcn.canhB = 5;
            double dt = hcn.DienTich();
            double cv = hcn.ChuVi();
            Console.WriteLine("Dien Tich: {0}",dt);
            Console.WriteLine("Chu Vi: {0}", cv);
        }
    }
}
