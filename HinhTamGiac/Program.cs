using System;

namespace HinhTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap 3 canh tam giac
            Console.WriteLine("Nhap canh a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh c");
            double c = double.Parse(Console.ReadLine());

            /* /IAsyncDisposableas
            asd
            asd
            as
            das
            das
            das
            a
            */
            double chuVi = a + b + c;
            double P = chuVi / 2;
            double dienTich =
                Math.Sqrt(
                    P
                    *(P - a)
                    *(P - b)
                    *(P - c)
                    );
            Console.WriteLine(
                @"CV:{0},DT:\{1}", 
                chuVi, 
                dienTich);
        }
    }
}
