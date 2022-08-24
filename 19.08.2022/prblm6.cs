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
        int year;
            Console.WriteLine("enter the value for year");
            year = Convert.ToInt32 (Console.ReadLine());
            if ((year%4)==0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
            Console.ReadLine();
        }
    }
}
