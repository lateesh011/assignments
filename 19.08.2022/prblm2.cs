using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._08._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("enter the value for c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for d");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for e");
            int e = Convert.ToInt32(Console.ReadLine());
            if (c > d && c > e)
            {
                Console.WriteLine($"greater is {c}");
            }
            else if (d > c && d > e)
            {
                Console.WriteLine($"greater is {d}");
            }
            else
            {
                Console.WriteLine($"greater is {e}");
            }
            Console.ReadLine();
        }
    }
}
