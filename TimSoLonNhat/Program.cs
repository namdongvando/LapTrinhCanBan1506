using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap 3 so nguyen tu ban phim
            Console.WriteLine("Nhap so a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c");
            int c = int.Parse(Console.ReadLine());
            // lam sao tìm so lớn nhát trong 3 số

            int max = a;
            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("So Lon Nhat la: {0}", max);
            int min = a;
            if (min > b)
            {
                min = b;
            }

            if (min > c)
            {
                min = c;
            }
            Console.WriteLine("So Nho Nhat la: {0}", min);
            Console.ReadKey();

        }
    }
}
