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
            prblm6txt.filecreation();
            
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusableCodeLibrary
{
    public class prblm6txt
    {
        public static void filecreation()
        {
            Console.WriteLine("Creating An Empty File");
            string path = @"D:\C#\solve\MyApp\files.txt";
            File.Create(path);
        }
    }
}
