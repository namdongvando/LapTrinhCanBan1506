using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThang
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Thang");
                int thang;
                bool kt = int.TryParse(
                    Console.ReadLine(),
                    out thang);

                if (kt == false)
                {
                    // nhap không dúng
                    throw new Exception(
                        "Bạn nhap chua dung dinh dang");
                }
                // đã nhập đúng dịnh dạng
                // kiểm tra giá trị đúng chua
                if (thang <= 0 || thang > 12)
                {
                    throw new Exception(
                        "Thang không hop le");
                }
                // thang hop lệ
                Console.WriteLine("Thang: {0}", thang);
                int nam;
                if (thang == 2)
                {
                    kt = int.TryParse(
                        Console.ReadLine(), out nam);
                    if (kt == false)
                    {
                        throw new Exception(
                            "Nam không dung dinh dang");
                    }
                    // có nam ,thang	
                    if (nam % 4 == 0)
                    {
                        Console.WriteLine("29 ngày");
                    }
                    else
                    {
                        Console.WriteLine("28 ngày");
                    }
                }
                else
                {
                    // có nam có thang
                    // 1,3,5,7,8,10,12 => 31 ngày
                    // 4,6,11,9 => 30 ngày
                    // 2 => 28,29 ngày
                    int ngay = 31;
                    if (thang == 4
                        || thang == 6
                        || thang == 11
                        || thang == 9)
                    {
                        ngay = 30;
                    }
                    Console.WriteLine("So Ngay: {0}", ngay);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
