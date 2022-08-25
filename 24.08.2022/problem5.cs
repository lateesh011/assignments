using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusablecodelibrary;

namespace Myapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the String");
            string s1 = Console.ReadLine();
            SampleClass1.Upper(s1);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecodelibrary
{
    public class SampleClass1
    {
        public static void Upper(string s)
        {
            string s2 = s.ToUpper();
            Console.WriteLine("Converted to " + s2);
        }
    }
}
