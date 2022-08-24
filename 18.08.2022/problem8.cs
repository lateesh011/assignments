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
            Console.Write("amount of celsius is ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double kelvin = celsius + 273.15;
            double fahrenheit = (celsius * 9 + (32 * 5)) / 5;
            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.ReadLine();

        }
    }
}
