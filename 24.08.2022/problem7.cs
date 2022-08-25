using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodeLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             date.Date();
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class date
    {
        public static void Date()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Displaying Today Date and Time Properties");
            Console.WriteLine("Year=" + dt.Year);
            Console.WriteLine("Month=  " + dt.Month);
            Console.WriteLine("Day=  " + dt.Day);
            Console.WriteLine("Hour = " + dt.Hour);
            Console.WriteLine("Minute = " + dt.Minute);
            Console.WriteLine("Second = " + dt.Second);
            Console.WriteLine("Millisecond = " + dt.Millisecond);
            Console.WriteLine("DayofWeek = " + dt.DayOfWeek);
            Console.WriteLine("Time = " + dt.TimeOfDay);

        }
    }
}
