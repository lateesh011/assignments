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
        Console.WriteLine("enter the kilometer value");
            double kilometer_ = Convert.ToDouble(Console.ReadLine());
            double meter_ = kilometer_ *1000;
            Console.WriteLine(meter_);
            Console.ReadLine();
        }
    }
}
