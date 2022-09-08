using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppercase;

namespace _7_Problem_7
{
    public delegate void Makingupper(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            FirstlettertoUpper upper = new FirstlettertoUpper();
            Makingupper m = new Makingupper(upper.Makeupper);
            m(s);
            Console.ReadLine();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppercase
{
    public class FirstlettertoUpper
    {
        public void Makeupper(string s)
        {
            string s2 = char.ToUpper(s[0]) + s.Substring(1);
            Console.WriteLine("After making the First Letter to Uppercase  : {0}" , s2);
        }
    }
}
