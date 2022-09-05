using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using catprodlibrary;

namespace _2_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category();
            c.AddCategory(1, "Beverage", "Soft Drink");
            

            Products p1 = new Products();
            p1.AddProduct(10, "Coke", "2 Litres", 40, "Litres", "100 Litres", 100);
            
            Products p2 = new Products();
            p2.AddProduct(11, "Pepsi", "5 Litres", 40, "Litres", "100 Litres", 200);
           
            List<Products> prodlist = new List<Products>();
            prodlist.Add(p1);
            prodlist.Add(p2);
            c.ListofCat = prodlist;


            c.DisplayDetails();
            Console.ReadLine();
        }
    }
}
