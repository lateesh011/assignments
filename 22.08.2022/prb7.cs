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
        Queue my_queue = new Queue();
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
            my_queue.Dequeue();
            Console.WriteLine("Total elements after deque in: {0}", my_queue.Count);
            Console.ReadKey();
        }
    }
}
