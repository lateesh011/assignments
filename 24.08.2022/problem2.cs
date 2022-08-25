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
            Console.WriteLine("Enter the String");
            string s1 = Console.ReadLine();
            StringCopymethod.Stringcopy(s1);

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
    public class StringCopymethod
    {
        public static void Stringcopy( string s1)
        {
            var s = string.Copy(s1);
            Console.WriteLine("Copied String" + " "+ s);
            
        }
    }
