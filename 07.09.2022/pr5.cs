using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeelibrary;

namespace _7_Problem5
{
    public delegate void CalculatingService();
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e =new Employee();
            Console.WriteLine("Enter the date");
            e.dateofjoining = Convert.ToDateTime(Console.ReadLine());
            CalculatingService se = new CalculatingService(e.calc);
            se();
            Console.ReadLine();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeelibrary
{
    public class Employee
    {
        public DateTime dateofjoining { get; set; }

        public void calc()
        {
            DateTime dt = DateTime.Now;
            int y = dt.Year;
            int y1  =dateofjoining.Year;
            int service = y - y1;
            Console.WriteLine("Total Years of Service :" + service);
        }
    }
}
