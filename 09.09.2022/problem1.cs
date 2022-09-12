using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem1
{
    internal class Program
    {
        public static void Method()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number :"  + i);

            }

        } 
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method);
            t1.Start();
            Console.ReadLine();

        }
    }
}
