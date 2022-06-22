using System;

namespace SuDungHamTT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            // xuat ra man hinh
            Console.WriteLine("======Menu=======");
            Console.WriteLine("1. Su Dung Vong lap");
            Console.WriteLine("2. Tim So Lon Nha");
            Console.WriteLine("3. Tỏng cac so 1-> 1/n");
            Console.WriteLine("4. Tinh N!");
            Console.WriteLine("5. Tinh tong tu 1 -> N");
            // cho nguoi dung chon 
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    SuDungVongLap(); 
                    break;
                case "5":
                    TinhTongToiN();
                    break;
                case "4":
                    TinhNGiaiThua();
                    break;
                case "3":
                    TinhTongDaySo();
                    break;

            }
            
        }

        private static void TinhTongDaySo()
        {
            try
            {
                Console.WriteLine("Nhap So Nguyen N");
                int n;
                bool kt =
                     int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    // nguoi dung nhap sai
                    throw new Exception("Chuỗi không đúng dịnh dạng");
                }
                // nhap đúng
                if (n <= 0)
                {
                    throw new Exception("N Phải Lớn Hơn 0");
                }
                double tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong = tong + 1.0/i;
                }
                Console.WriteLine("N!={0}", tong);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// tính N!
        /// </summary>
        private static void TinhNGiaiThua()
        {
            try
            {
                Console.WriteLine("Nhap So Nguyen N");
                int n;
               bool kt =
                    int.TryParse(Console.ReadLine(), out n);
                if(kt == false)
                {
                    // nguoi dung nhap sai
                    throw new Exception("Chuỗi không đúng dịnh dạng");
                }
                // nhap đúng
                if (n <= 0)
                {
                    throw new Exception("N Phải Lớn Hơn 0");
                }
                int giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua = giaiThua * i;
                }
                Console.WriteLine("N!={0}", giaiThua);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static void TinhTongToiN()
        {
            try
            {
                //Nhap so nguyen N
                Console.WriteLine("Nhap So nguyen N");
                int n = int.Parse(Console.ReadLine());
                int tong = 0;
                for (int i = 1; i <=n ; i++)
                {
                    tong = tong + i;
                }
                Console.WriteLine("Tong Toi N La: {0}", tong);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }  
        }

        private static void SuDungVongLap()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin chao");
                Console.WriteLine(i+1);
            }
        }
    }
}
