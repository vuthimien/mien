using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[100];
            int so, count = 0;
            Console.Write("Nhap kich co mang:");
            so = int.Parse(Console.ReadLine());

            for (int i = 0; i < so; i++)
            {
                Console.WriteLine("Nhap so thu {0}:", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < so; i++)
            {
                if (mang[i] % 2 == 1)
                    Console.WriteLine("so le:" + mang[i]);
                count++;
            }
            if (count == 0)
                Console.WriteLine("Không có số lẻ");

        }
    }
}
