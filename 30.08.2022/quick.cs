using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 14, 7, 11, 8, 99, 56,34 };
            QuickSort(arr, 0, arr.Length - 1);
            int n = arr.Length;
            PrintsortedArray(arr, n);
            Console.Read();
        }

        private static void PrintsortedArray(int[] arr, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = makePart(arr, start, end);
                QuickSort(arr, start, p - 1);
                QuickSort(arr, p + 1, end);

            }

        }

        private static int makePart(int[] arr, int start, int end)
        {
            
            int pivot = arr[end];
            int i = (start - 1);
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;

                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
    }
 }
