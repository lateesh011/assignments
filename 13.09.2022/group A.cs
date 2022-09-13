using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_groupA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\C#\\12Sep\\12 A\\Calculator\\bin\\Debug\\Calculator.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;

            
            foreach (var item in types)
            { 
                t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);
                Console.Write("Enter the Number  :");
                double n = Convert.ToInt32(Console.ReadLine());
                
                item.InvokeMember("AcceptNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj,
               new object[1] { n });

                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                item.InvokeMember("Sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);



            }
            Console.ReadLine();
        }
    }
}
--------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double Number { get; set; }

        public void AcceptNumber(double n)
        {
            Number = n;
        }

        public void Cube()
        {
            double n1 = Number * Number * Number;
            Console.WriteLine("Cube of the Entered Number :" + n1);

        }

        public void Sqrt()
        {
            double n2 = Math.Sqrt(Number);
            Console.WriteLine("Square Root of the Entered Number :" + n2);
        }
    }
}
