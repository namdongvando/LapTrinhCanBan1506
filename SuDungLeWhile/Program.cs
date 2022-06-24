using System;

namespace SuDungLeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // UCLN();
            //XacDinhSoNguyenTo();
            // XacDinhSoNguyenToWhile();

            int a = NhapSoNguyen();
            int b = NhapSoNguyenDuong();

        }

        private static int NhapSoNguyenDuong()
        {
            int a;
            bool kt;
            Console.WriteLine("Nhap so nguyen duong");
            do
            {
                kt = int.TryParse(Console.ReadLine(),out  a);
                if (kt == true) {
                    if (a <= 0)
                    {
                        kt = false;
                    }
                }
                if (kt == false)
                {
                    Console.WriteLine("Nhap lai");
                }

            } while (kt==false);
            return a;
        }

        private static int NhapSoNguyen()
        {
            int a;
            Console.WriteLine("Nhap so nguyen");
            while (
                int.TryParse(
                    Console.ReadLine(),out a) 
                == false)
            {
                Console.WriteLine("Nhap Lai");
            } 
            return a;
        }

        private static void XacDinhSoNguyenToWhile()
        {
            Console.WriteLine("Nhap so nguyen a");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while(i <= n)
            {
                if(n%i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine("{0} la so nguyenb to");
                    }
                    else
                    {
                        Console.WriteLine("{0} khong phai so nguyenb to");
                    }
                    break;
                } 
                i++;
            }

        }

        private static void XacDinhSoNguyenTo()
        {
            Console.WriteLine("Nhap So nguyen N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine("{0} la so nguyen to", n);
                    }
                    else
                    {
                        Console.WriteLine("{0} khong phai so nguyen to", n);
                    }
                    break;
                }

            }
        }

        private static void UCLN()
        {
            //
            Console.WriteLine("Nhap a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            int b = int.Parse(Console.ReadLine());

            while (a * b > 0)
            {
                if (a < b)
                {
                    b = b % a;
                }
                else
                {
                    a = a % b;
                }
            }
            Console.WriteLine("UCLN La: {0}", a + b);

        }
    }
}
