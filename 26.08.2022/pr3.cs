using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace 26_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product()
            {
                Pid = 1,
                Pname = "Kitkat",
                Description = "Candy"
            };
            Product p2 = new Product()
            {
                Pid = 2,
                Pname = "Oreo",
                Description = "Cookie"
            };
            Product p3 = new Product()
            {
                Pid = 3,
                Pname = "GoodDay",
                Description = "Cookie"
            };
            List<Product> list = new List<Product>(2);
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            foreach (var item in list)
            {
                Console.WriteLine(item.Pid);
                Console.WriteLine(item.Pname);
                Console.WriteLine(item.Description);

            }

            Console.WriteLine("-------------AFter Removing p1--------------------------");
            list.Remove(p1);
            foreach (var item in list)
            {
                Console.WriteLine(item.Pid);
                Console.WriteLine(item.Pname);
                Console.WriteLine(item.Description);

            }
            Console.ReadLine();
        }
       

    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Class1
    {
    }
        public class Product
        {
            public int Pid { get; set; }
            public string Pname { get; set; }
            public string Description { get; set; }

        }
    }
