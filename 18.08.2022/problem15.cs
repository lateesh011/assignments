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
        Console.WriteLine("enter the us dolar u have");
            double dollar = Convert.ToDouble(Console.ReadLine());
            double INR = dollar * 62;
            Console.WriteLine(INR);
            Console.ReadLine();
        }
    }
}
