using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackusinggeneric
{
    class PS1
    {

        static void Main(string[] args)
        {
            GenericsLinkedList<string> stringLinkedList = new GenericsLinkedList<string>(); //object 1
            string s1 = "String 1";
            string s2 = "String 2";
            string s3 = "String 3";
            string s4 = "String 4";
            stringLinkedList.AddHead(s1);
            stringLinkedList.AddHead(s2);
            stringLinkedList.AddHead(s3);
            stringLinkedList.AddHead(s4);
            //display List
            foreach (string str in stringLinkedList)
            {
                Console.WriteLine(str);
            }
            GenericsLinkedList<int> integerList = new GenericsLinkedList<int>();
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;

            integerList.AddHead(n1);
            integerList.AddHead(n2);
            integerList.AddHead(n3);

            foreach (int Intger in integerList)
            {
                Console.WriteLine(Intger);
            }


            Console.ReadKey();


        }
    }
    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Userstack<string> u = new Userstack<string>();
            u.Push("America");
            u.Push("Russia");
            u.Push("India");
            Console.WriteLine("Popped element");
            u.Pop();
            Console.WriteLine("Elements at present");
            u.printData();
            Console.WriteLine("Top element at present");
            string k = u.Peek();
            Console.WriteLine(k);
            Console.ReadLine();
           

        }

    }
    class Userstack<T>
    {
        internal static int max = 1000;
        T[] stack=new T[max];
        int top=-1;
        public void Push(T str)
        {
            if (top >= 1000)
            {
                Console.WriteLine("can't push");
            }
            else
            {
                stack[++top] = str;
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements there to pop");
            }
            else
            {
                T value=stack[top--];
                Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            if (top < 0)
            {
                return default(T);
            }
            else
            {
                T value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
