using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calclibrary;

namespace _7_problem3
{
    public delegate void Calculations(int i, int j);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int j = Convert.ToInt32(Console.ReadLine());
           
            Operations op = new Operations();
            Calculations c1 = new Calculations(op.add);
            c1(i, j);
            Calculations c2 = new Calculations(op.sub);
            c2(i, j);
            Calculations c3 = new Calculations(op.mul);
            c3(i, j);
            Console.ReadLine();
        }
    }
}
====================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calclibrary
{
    public class Operations
    {
        public void add(int i, int j)
        {
            int k = i + j;
            Console.WriteLine("Additon of {0} and {1} is {2}", i, j, k);
        }

        public void sub(int i, int j)
        {
            int k = i - j;
            Console.WriteLine("Subtraction of {0} and {1} is {2}", i, j, k);
        }

        public void mul(int i, int j)
        {
            int k = i * j;
            Console.WriteLine("Multiplication of {0} and {1} is {2}", i, j, k);
        }
    }
}
