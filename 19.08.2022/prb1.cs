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
        int a;
            Console.WriteLine("enter the value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"maximum number is {a}");
                Console.WriteLine($"minimum number is {b}");
            }
            else
            {
                Console.WriteLine($"maximum number is {b}");
                Console.WriteLine($"minimum number is {a}");
            }
            Console.ReadLine();
        }
    }
}
