using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap A");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("La So Chan");
            }
            else { 
                Console.WriteLine("La So Le");
            }
            Console.ReadKey(); 
        }
    }
}
