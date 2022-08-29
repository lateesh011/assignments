using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sLibrary;

namespace _26_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] stud = new Student[2];

            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
                Console.WriteLine("Enter Rollno");
                stud[i].Rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                stud[i].Sname = Console.ReadLine();
                Console.WriteLine("Enter Standard");
                stud[i].Standard = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("----------------------");

            foreach (var item in stud)
            {
                Console.WriteLine("Printing the details");
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.Sname);
                Console.WriteLine(item.Standard);
                Console.WriteLine("-----------------------------------------------");
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student
    {

        private int _rollno;

        public int Rollno
        {
            get { return _rollno; }
            set { _rollno = value; }
        }


        private string _sname;

        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }


        private int _standard;

        public int Standard
        {
            get { return _standard; }
            set { _standard = value; }
        }
    }
}
