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
        Console.WriteLine("enter the string1");
            string string1 = Console.ReadLine();
            Console.WriteLine("enter the string2");
            string string2 = Console.ReadLine();
            if (string1 == string2)
            {
                Console.WriteLine("both the string are equal");
            }
            else
            {
                Console.WriteLine("both the string are not equal");
            }
            Console.ReadLine();
        }
    }
}
