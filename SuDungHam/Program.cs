using System;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); 

            //XinChao();
            //XinChao("Teo");
            //PhuongTrinhBac1();
            //PhuongTrinhBac2();
           // Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("========Menu=========");
            Console.WriteLine("1. Phuong Trinh Bac 1");
            Console.WriteLine("2. Phuong Trinh Bac 2");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1": PhuongTrinhBac1();
                    break;
                case "2":
                    PhuongTrinhBac2();
                    break;
                case "exit":
                    return; 
            }
            Menu();

        }

        private static void PhuongTrinhBac2()
        {
            Console.WriteLine("Nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            double c = double.Parse(Console.ReadLine()); 
            double d = Math.Pow(b, 2) - 4 * a * c;
            try
            {
                if(d<0)
                {
                    throw new Exception("VN");
                }
                // d >= 0
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1={0},X2={1}", x1, x2);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            } 
        }

        private static void PhuongTrinhBac1()
        {
            // giai pt bac 1
            // ax + b = 0
            Console.WriteLine("Nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            double b = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                if (b == 0)
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
                Console.WriteLine("X=:{0}", -b / a);
            }

        }

        private static void XinChao(string hoTen)
        {
            Console.WriteLine("Xin Chao: {0}", hoTen);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin chao");
        }
    }
}
