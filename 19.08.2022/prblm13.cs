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
        int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Entered Number is" + " " + num);

            }
            else if (num % 2 == 0 && num <= 100)
            {
                Console.WriteLine("Entered Number is Even ");
            }
            else if (num % 2 != 0 && num <= 100)
            {
                Console.WriteLine("Entered Number is Odd ");
            }
            else
            {
                Console.WriteLine("Entered Number is too large ");
            }

            if (num % 10 == 0)
            {
                Console.WriteLine("Entered number is multiple of 10");
            }
            Console.ReadLine();
        }
    }
}
