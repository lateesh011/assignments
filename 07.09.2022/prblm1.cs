using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr1;

namespace _7sep_Problem_1
{
    public delegate void Lengthofstring(string s1);    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            Flength p = new Flength();
            Lengthofstring del = new Lengthofstring(p.Findlength);
            del(s);
            Console.ReadLine(); 

            
        }
    }
}
-----------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class Flength
    {
        public void Findlength(string s1)
        {
            int i = s1.Length;
            Console.WriteLine("The length of the String :" + i);
        }
    }
}
