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
            double o = Convert.ToDouble(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());
            bool resu = (o > 0 && l > 0);
            Console.WriteLine(resu);
            Console.ReadLine();
        }
    }
}
