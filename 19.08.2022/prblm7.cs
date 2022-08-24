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
        Console.WriteLine("enter the math subject marks");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the english marks");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the science");
            int science = Convert.ToInt32(Console.ReadLine());
            int result = (math + english + science) / 3;
            if (result < 35)
            {
                Console.WriteLine("fail");
            }
            else if (result > 35 && result <
                45)
            {
                Console.WriteLine("third");
            }
            else if (result > 45 && result <
                60)
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("first");
            }
            Console.ReadLine();
			
        }
    }
}
