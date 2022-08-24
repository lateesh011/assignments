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
        Console.WriteLine("Enter the First number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int k = Convert.ToInt32(Console.ReadLine());
            int w = m * j * k;
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
