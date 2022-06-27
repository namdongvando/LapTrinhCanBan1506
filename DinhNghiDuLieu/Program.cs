using System;

namespace DinhNghiDuLieu
{

    class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }

        public string ThongTinSinhVien() {

            return string.Format("{0}|{1}|{2}|{3}",MaSinhVien,HoTen,NgaySinh,GioiTinh);
        }

    }
     
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SinhVien Teo = new SinhVien();
            Teo.HoTen = "Teo Nguyen";
            Teo.MaSinhVien = "SV01111";
            Teo.NgaySinh = new DateTime(2000, 1, 1);
            Teo.GioiTinh = 1;
            
            Console.WriteLine(Teo.ThongTinSinhVien());

            Console.WriteLine(Teo.HoTen);
            SinhVien Ti = new SinhVien()
            {
                HoTen = "Ti Nguyen Van",
                MaSinhVien = "sv002123",
                NgaySinh = new DateTime(2000, 1, 1),
                GioiTinh = 1
            };
            Console.WriteLine(Ti.ThongTinSinhVien());
        }
    }
}
