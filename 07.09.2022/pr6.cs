using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using concatlibrary;

namespace _7sep_Problem6
{
    public delegate void Constring(string s1, string s2);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the Second string");
            string s2 = Console.ReadLine();
            Concat c = new Concat();
            Constring c1 = new Constring(c.Concatstring);
            c1(s1, s2);
            Console.ReadLine();


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatlibrary
{
    public class Concat
    {
        public void Concatstring(string s1, string s2)
        {
            string s3 = string.Concat(s1, s2);
            Console.WriteLine("Concatenated string :" + s3);
        }
    }
}
