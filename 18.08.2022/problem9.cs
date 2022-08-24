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
            Console.WriteLine("enter the value");
            double h = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            bool res = (h > 0 && p < 0) || (h < 0 && p > 0);
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
