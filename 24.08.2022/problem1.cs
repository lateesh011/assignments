using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodeLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string s2 = Console.ReadLine();
            StringComparemethod.stringcompare(s1, s2);
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class StringComparemethod
    {
        public static void stringcompare(string s1, string s2)
        {
            
            if (s1 == s2)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }
    }
}
