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
        Console.WriteLine("enter the c1");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the c2");
            char c2 = Convert.ToChar(Console.ReadLine());
            if (c1 == c2)
                Console.WriteLine("Both characters are equal");
            else
                Console.WriteLine("Characters are not equal");
            Console.ReadLine();
        }
    }
}
