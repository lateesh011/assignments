using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem2
{
    internal class Program
    {
        public static void M1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
                Console.WriteLine();
                Console.WriteLine("Numbers :" +i);
                Thread.Sleep(2000);

            }
        }

        public static void M2()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
                Console.WriteLine("Numbers :" + i);
                Thread.Sleep(2000);

            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(M2);
            t2.Name = "Thread 2";
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Abort();
            t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
            Console.ReadLine();
        }
    }
}
