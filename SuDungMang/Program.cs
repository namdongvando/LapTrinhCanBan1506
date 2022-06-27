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
            int[] a = NhapMang();
            // Tinh Tong Gia Tri Trong Mang
            //int tong = TongGiaTriMang(a);
            //Console.WriteLine("Tong: {0}",tong);
            int[] b = SapXepMang(a);
            int[] c = SapXepMangC2(a);
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        private static int[] SapXepMangC2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int viTriMin = i;
                // tim vi trí giá trị nhỏ nhất
                for (int j = i; j < a.Length; j++)
                {
                    if(a[j] < a[viTriMin])
                    {
                        viTriMin = j;
                    }
                }
                // tim dc vi trí giá trị nhỏ nhất
                //hoan vi
                int tam = a[i];
                a[i] = a[viTriMin];
                a[viTriMin] = tam;
            }
            return a;
        }

        private static int[] SapXepMang(int[] a)
        {
            int i = 0;
            while (i < a.Length-1)
            {
                if(a[i] > a[i + 1])
                {
                    // hoan vi
                    int tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam; 
                    i = 0;
                }
                else
                {
                    i++;
                }
            } 
            return a;
        }

        private static int TongGiaTriMang(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
                // tong = tong +a[i];
            }
            return tong;
        }

        private static int[] NhapMang()
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
            return a;
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
