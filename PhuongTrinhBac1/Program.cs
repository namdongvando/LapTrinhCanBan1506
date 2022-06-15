using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nhap So A");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap So B");
            double b = Double.Parse(Console.ReadLine());

            if (a==0)
            {
                if (b==0)
                {
                    Console.WriteLine("VSN");
                }
                else
                {
                    Console.WriteLine("VN");
                }
            }
            else
            {
                Console.WriteLine("X = {0:f2}", -b / a);
            }
            Console.ReadKey();
        }
    }
}
