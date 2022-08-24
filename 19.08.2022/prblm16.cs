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
        int points = 100, count = 0;
            while (count<4)
            {
                string s = Console.ReadLine();
                if (s=="HIT")
                {
                    points += 10;
                }
                else if (s=="MISS")
                {
                    points -= 20;
                }
                else
                {
                    Console.WriteLine("enter valid input");
                    break;
                }
                count++;    
            }
            Console.WriteLine(points);
            Console.ReadLine();
        }
    }
}
