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
        Stack st = new Stack();
                st.Push(1);
                st.Push(2);
                st.Push(3);
                st.Pop();
                foreach (Object obj in st)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("The number of elements in the stack " + st.Count);
                Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
                Console.ReadKey();
        }
    }
}
