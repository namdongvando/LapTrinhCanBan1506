using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocLuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Diem");
            double diem = Double.Parse(Console.ReadLine());
            if (diem >= 0 && diem <3.5)
            {
                Console.WriteLine("kem");
            }
            if (diem >= 3.5 && diem < 5)
            {
                Console.WriteLine("Yeu");
            }
            if (diem >= 5 && diem < 6.5)
            {
                Console.WriteLine("TB");
            }
            if (diem >= 6.5 && diem < 8.5)
            {
                Console.WriteLine("Kha");
            }
            if (diem >= 8.5 && diem <= 10)
            {
                Console.WriteLine("Gio");
            }

            //
            if(diem < 3.5)
            {
                Console.WriteLine("Kem");
            } 
            else if (diem < 5)
            {
                Console.WriteLine("Yeu");
            }
            else if (diem < 6.5)
            {
                Console.WriteLine("TB");
            }
            else if (diem < 8.5)
            {
                Console.WriteLine("Kha");
            }
            else 
            {
                Console.WriteLine("Gio");
            }

            Console.ReadKey();

        }
    }
}
