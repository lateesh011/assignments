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
            int number1, number2, number3;

            Console.Write("Enter first number - ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4} \n\n",
                number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
            Console.ReadLine();
        }
    }
}
