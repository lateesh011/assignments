using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("enter the meter value");
            double meter = Convert.ToDouble(Console.ReadLine());
            double kilometer = meter / 1000;
            Console.WriteLine(kilometer);
            Console.ReadLine();
        }
    }
}
