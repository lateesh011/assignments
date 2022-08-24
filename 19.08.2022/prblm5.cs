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
        int x;
            Console.WriteLine("enter the value for x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("greater is x");
            }
            else
            {
                Console.WriteLine("greater is y");
            }
            Console.ReadLine();
        }
    }
}
