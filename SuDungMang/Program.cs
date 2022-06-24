using System;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {

            //KhaiBaoMang();
            //XuatMangRaManHinh();
            //XuatSoChanTrongMang();
            //TimGiaTriLonNhatTrongMang();
            NhapMang();

        }

        private static void NhapMang()
        { 
            int soPhanTu = NhapSoNguyenDuong("Nhap So Phan Tu");
            // khai bao mang
            int[] a = new int[soPhanTu];
            // nhap mang
            for (int i = 0; i < soPhanTu; i++)
            {
              //  a[i] = NhapSoNguyenDuong("Nhap Phan Tu Thu " + i+1);
                a[i] = NhapSoNguyenDuong(
                    string.Format("Nhap Phan Tu Thu {0}",i+1)
                    );
            }
            // xuat mang
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static int NhapSoNguyenDuong(string thongBao)
        {
            int a;
            bool kt;
            Console.WriteLine(thongBao);
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                {
                    if (a <= 0)
                    {
                        kt = false;
                    }
                }
                if (kt == false)
                {
                    Console.WriteLine("Nhap lai");
                }

            } while (kt == false);
            return a;
        }

        private static void TimGiaTriLonNhatTrongMang()
        {

            int[] a = { 23, 23, 42, 3423, 42, 34, 23 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] > max)
                    max = a[i];
            // xuat ra man hinh
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            Console.WriteLine("Max la:{0}",max);

        }

        private static void XuatSoChanTrongMang()
        {
            int[] a = { 2342, 23, 42342, 34, 234, 23 };
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 0)
                {
                    Console.WriteLine("{0} la So Chan",a[i]);
                }
                else
                {
                    Console.WriteLine("{0} la So Le", a[i]);
                }
            }
        }

        private static void XuatMangRaManHinh()
        {
            int[] a = { 23, 423, 2, 2, 3, 23, 23, 421, 3413, 42 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void KhaiBaoMang()
        {
            int[] a = { 23, 23, 2, 2, 32, 2, 32, 12};
            int[] b= new int[4];
        }
    }
}
