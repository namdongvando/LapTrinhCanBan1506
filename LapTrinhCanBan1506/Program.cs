using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhCanBan1506
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin chao");
            Console.WriteLine("Xin chao");
            //xuất ra man hinh
            Console.WriteLine("Nhap ho ten");
            // nhap tu ban phim
            string hoTen = Console.ReadLine();
            Console.WriteLine("xin chao: {0}", hoTen);

            //nhap nam sinh
            Console.WriteLine("Nhap nam sinh");
            string namSinh = Console.ReadLine();
            int nam = int.Parse(namSinh);
            int tuoi = DateTime.Now.Year - nam;
            Console.WriteLine("Tuoi: {0}", tuoi);
            Console.ReadKey();
        }
    }
}
