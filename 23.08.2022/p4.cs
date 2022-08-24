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
        static void Main(string[] args)
        {
            employee e = new employee();
            Console.WriteLine("Enter Employee Number ");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name ");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary ");
            int sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Dept Number ");
            int deptno = Convert.ToInt32(Console.ReadLine());

            e.AcceptemployeeData(empno, ename, sal, deptno);
            Console.WriteLine("-------Now Printing The Details---------");
            e.DisplayInfo();
            Console.ReadLine();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    class Class2
    {
     struct employee
    {
        int empno;
        string ename;
        int sal;
        int deptno;

        public void AcceptemployeeData(int empno, string ename, int sal,int deptno)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
            this.deptno= deptno;    
        }
        public void DisplayInfo()
        {
            Console.WriteLine(empno);
            Console.WriteLine(ename);
            Console.WriteLine(sal);
            Console.WriteLine(deptno);
            

        }
    }
}

