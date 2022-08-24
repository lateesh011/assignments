using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    class Program
    {
        enum Departments
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Account = 4
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Departments.Purchase);
            int d1 = (int)Departments.Purchase;
            Console.WriteLine(d1);
            Console.WriteLine(Departments.Sales);
            int d2 = (int)Departments.Sales;
            Console.WriteLine(d2);
            Console.WriteLine(Departments.Training);
            int d3 = (int)Departments.Training;
            Console.WriteLine(d3);
            Console.WriteLine(Departments.Account);
            int d4 = (int)Departments.Account;
            Console.WriteLine(d4);
            Console.ReadLine();
        }
    }
}

