
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int j = Convert.ToInt32(Console.ReadLine());
            try
            {
                int k = i / j;
                Console.WriteLine(k);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("This is Divided by Zero Exception");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
    
}
