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
        int num, userchoice;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the userchoice");
            userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    if (num == 0)
                        Console.WriteLine("Entered number is" + num);
                    break;
                case 2:
                    if (num % 2 == 0 && num <= 100)
                        Console.WriteLine("Entered number is Even");
                    if (num % 10 == 0)
                        Console.WriteLine("Entered number is Multiples of 10");
                    break;
                case 3:
                    if (num % 2 != 0 && num <= 100)
                        Console.WriteLine("Entered number is Odd");
                    break;
                case 4:
                    if (num > 100)
                        Console.WriteLine("Entered number is Large");
                    break;
                default:
                    break;
        }
    }
}
