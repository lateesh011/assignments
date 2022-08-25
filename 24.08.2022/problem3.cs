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
             Indexof_method.Index();
            
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
    public class Indexof_method
    {
        public static void Index()
        {
            string s = "Welcome";
            Console.WriteLine("Welcome");
            int i = s.IndexOf('c');
            Console.WriteLine("Indefof c is  " + i);
        }
    }
}
