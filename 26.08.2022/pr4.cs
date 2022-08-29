using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Hello");
            mylist.AddLast("C sharp");
            mylist.AddAfter(mylist.First,"All" );
            mylist.AddBefore(mylist.Last, "my");
            mylist.AddBefore(mylist.Last.Previous, "to");
            mylist.AddAfter(mylist.First.Next, "Welcome");
        
            foreach (var item in mylist)
            {
                Console.Write(item +"\t");

            }
            Console.WriteLine("\n -----------------After Using Find-------------------");
            LinkedListNode<string> foundnode = mylist.Find("C#");
            foundnode.Value = "Python";
            foreach (var item in mylist)
            {
                Console.Write(item + "\t");

            }
            Console.ReadKey();
        }
    }
}
