using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] array1 = { 34, 56, 78, 100, 200, 300,
                     450, 324, 56, 77, 890 };
            var big = from value in array1 where value > 100 select value;
            Console.WriteLine("Numbers that are greater than 100 are  :");
            
            foreach (var s in big)
            {
                Console.Write(s.ToString() + " ");
            }
            Console.Read();
        }
    }
}
