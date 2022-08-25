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
            splitmethod.Split();
            
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
    public class splitmethod
    {
        public static void Split()
        {
            string s = "Welcome to the world of C# Programming";
            
            string[] result = s.Split('#');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            

        }
    }
