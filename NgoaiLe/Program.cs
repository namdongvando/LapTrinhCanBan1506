using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoaiLe
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Nhap So Nguyen A");
				int a;
				bool kt = int.TryParse(Console.ReadLine(), out a);
				if(kt == false)
				{
					// không phai so nguyen
					throw new Exception("Ban nhan khong dung!");
				}
				Console.WriteLine("A la: {0}", a);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();

        }
    }
}
