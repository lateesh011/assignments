using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 5library;

namespace _7sep_Problem_4
{
    public delegate void Print();    
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Products products = new Products();
            Console.WriteLine("Enter the Product ID");
            products.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product Name");
            products.ProductName = Console.ReadLine();
            Print p = new Print(products.DisplayDetails);
            p();

            Console.ReadLine();


        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 5library
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Product Id :" + ProductId);
            Console.WriteLine("Product Name :" + ProductName);
        }
    }
}
