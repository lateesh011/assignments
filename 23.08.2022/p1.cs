using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2;
                int sum;

                Console.Write("Enter first number: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                sum=addition(n1, n2);
                Console.WriteLine("The Sum is: " + sum);
                Console.ReadLine();
            }
            public static int addition(int n1, int n2)
            {
            return (n1 + n2);
            }

        }
    }
    
}

