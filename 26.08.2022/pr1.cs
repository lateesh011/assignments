using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[2];
            for (int i = 0; i < stud.Length; i++)
            {
                Student st = new Student();
                Console.WriteLine("Enter Roll Number ");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name ");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter Student Standard ");
                int standard = Convert.ToInt32(Console.ReadLine());
                st. AcceptstudentData(rollno, sname, standard);
                Console.WriteLine("-------Now Printing The Details---------");
                st.DisplayInfo();
                Console.WriteLine("--------------------------------");

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

namespace _26_1
{
    public class prblm1
    {
        struct Student
        {
            public int rollno;
            public string sname;
            public int standard;


            public void AcceptstudentData(int rollno, string sname, int standard)
            {
                this.rollno = rollno;
                this.sname = sname;
                this.standard = standard;

            }
            public void DisplayInfo()
            {
                Console.WriteLine("Rollno :" + rollno);
                Console.WriteLine("Student Name :" + sname);
                Console.WriteLine("Standard :" + standard);



            }
        }
    }
}
