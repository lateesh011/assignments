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
            int firstone;
            Console.WriteLine("enter the value for first number");
            firstone = Convert.ToInt32(Console.ReadLine());
            int second;
            Console.WriteLine("enter the value for second number");
            second = Convert.ToInt32(Console.ReadLine());
            int third;
            Console.WriteLine("enter the value for third number");
            third = Convert.ToInt32(Console.ReadLine());
            int result = (firstone + second + third) / 3;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
