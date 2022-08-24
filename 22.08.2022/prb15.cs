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
        int min = -1;
            int[] arr = new int[] { 10, 5, 4, 5, 6 };
            HashSet<int> set = new HashSet<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else 
                {
                    set.Add(arr[i]);
                }

            }

            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();
        }
    }
}
