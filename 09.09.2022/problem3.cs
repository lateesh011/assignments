using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace problem3
{
    internal class Program
    {
        public static void M1()
        {
            Console.WriteLine("Thread name " + Thread.CurrentThread.Name);
            Console.WriteLine("Method 1");
        }
        public static void M2()
        {
            Console.WriteLine("Thread name " + Thread.CurrentThread.Name);
            Console.WriteLine("Method 2");
        }
        public static void M3()
        {
            Console.WriteLine("Thread name " + Thread.CurrentThread.Name);
            Console.WriteLine("Method 3");
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(M2);
            t2.Name = "Thread 2";
            Thread t3 = new Thread(M3);
            t3.Name = "Thread 3";

            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();

        }
    }
}
