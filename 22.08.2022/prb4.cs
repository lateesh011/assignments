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
        ArrayList My_array = new ArrayList();

            My_array.Add(12.56);
            My_array.Add("GeeksforGeeks");
            My_array.Add(null);
            My_array.Add('G');
            My_array.Add(1234);
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }
            My_array.Remove(12.56);
            My_array.Remove(12);
            Console.WriteLine("After Remove() method the " +
              "number of elements: " + My_array.Count);
            Console.ReadKey();
        }
    }
}
