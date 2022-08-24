using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
        List<float> mylist = new List<float>();
            mylist.Add(45.34f);
            mylist.Add(25.28f);
            mylist.Add(98.64f);
            mylist.Add(12.34f);
            mylist.Add(38.12f);
            mylist.Sort();
            Console.WriteLine("Ascending Order");
            foreach (var i in mylist)
            {
                Console.Write(i +"\t");
            }   
            mylist.Reverse();
            Console.WriteLine("\n Descending Order");
            foreach (var i in mylist)
            {
                Console.Write(i +"\t");
            }
            Console.ReadLine();
        }
    }
}
