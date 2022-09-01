using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[] { 1, 21, 48, 23, 7, 65, 29, 54, 76 };
                SelectionSort(arr);


            }
        }
            static void SelectionSort(int[] arr)
            {
                int MinIndex, i, j;
                int len = arr.Length - 1;
                for (i = 0; i < len; i++)
                {
                    MinIndex = i;
                    for (j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[MinIndex])
                        {
                            MinIndex = j;
                        }
                    }
                    if (MinIndex != i)
                    {
                        int temp = arr[MinIndex];
                        arr[MinIndex] = arr[i];
                        arr[i] = temp;
                    }
                }

                Console.WriteLine("------------Sorted--------");
                for (int k = 0; k < arr.Length; k++)
                {
                    Console.WriteLine(arr[k]);
                }
            Console.Read();

        }
        }
}
