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
        int sum = 0;
            for (int i = 100; i <= 200; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of integers from 100 to 200: {0}", sum);
            Console.ReadLine();
        
        }
    }
}
