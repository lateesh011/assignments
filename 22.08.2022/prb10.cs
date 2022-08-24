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
        Dictionary<int, string> My_dict = new Dictionary<int, string>();
            My_dict.Add(1123, "Welcome");
            My_dict.Add(1124, "to");
            My_dict.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();
            My_dict.Remove(1123);
            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();
            My_dict.Clear();

            Console.WriteLine("Total number of key/value " +
             "pairs present in My_dict:{0}", My_dict.Count);
            Console.ReadKey();
        }
    }
}
