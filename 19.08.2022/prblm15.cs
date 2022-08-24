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
        int j = 25;
            for ( int i = 0; i <25; i++)
            {
                
                Console.WriteLine("{0} {1}", i, j);
                j--;
                if (i > j)
                {
                    Console.WriteLine("Crossed Over");
                    break;
                }
               
            }
            
            Console.ReadLine();
        }
    }
}
