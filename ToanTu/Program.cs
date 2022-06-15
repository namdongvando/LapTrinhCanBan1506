using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Nhap A");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap B");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Tong A + B = {0}",a+b);
            Console.WriteLine("Hieu A - B = {0}", a - b);
            Console.WriteLine("Tich A * B = {0}", a * b);
            Console.WriteLine("Thuong A / B = {0}", a / b);
            Console.ReadKey();
        }
    }
}
