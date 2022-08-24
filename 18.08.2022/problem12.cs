using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("enter the string");
            string pk = Convert.ToString(Console.ReadLine());
            bool resul = string.IsNullOrEmpty(pk);
            Console.WriteLine(resul);
            Console.ReadLine();
        }
    }
}
