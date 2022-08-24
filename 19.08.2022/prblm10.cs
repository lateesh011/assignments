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
        Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int t = num; t != 0; t = t / 10)
            {
                int r = t % 10;
                int s = 0;
                s = s * 10 + r;
                Console.Write("{0}", s);
            }
            Console.ReadLine();
        }
    }
}
