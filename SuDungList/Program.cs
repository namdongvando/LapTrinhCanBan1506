using System;
using System.Collections.Generic;

namespace SuDungList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhSachA = new List<int>();
            int[] a = new int[6];
            danhSachA.Add(8);
            danhSachA.Add(12);
            danhSachA.Add(83);
            danhSachA.Add(854);
            danhSachA.Add(6568);
            danhSachA.Add(8675);
            for (int i = 0; i < danhSachA.Count; i++)
            {
                Console.WriteLine(danhSachA[i]);
            }
            foreach (int item in danhSachA)
            {
                Console.WriteLine(item);
            }

            danhSachA.RemoveAt(1);
            danhSachA.RemoveAll(item => item < 100);

            // tim tát ca các thanh phan lon hon 100
            int b = danhSachA.Find(_item => _item > 100);

            Console.WriteLine(b);

        }
    }
}
