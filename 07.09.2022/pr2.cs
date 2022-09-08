using user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Problem2
{
    public delegate void guser(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine(); 
            Greet greet = new Greet();
            guser g = new guser(greet.greetinguser);
            g(s);
            Console.ReadKey();

        }
    }
}
===============================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    public class Greet
    {
        public void greetinguser(string s)
        {
            Console.WriteLine("Hello {0} Welcome To C#",s );

        }
    }
}
