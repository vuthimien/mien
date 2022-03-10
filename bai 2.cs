using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s = 0;
            int count = 1;
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {             
                    s = s + 1 / (float)i;
                count++;
            }
            Console.WriteLine("tong la:"+s);
        }
    }
}
