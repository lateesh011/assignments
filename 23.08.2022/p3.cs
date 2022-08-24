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
            employee e1 = new employee();
            Console.WriteLine("Enter Employee Number ");
            e1.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name ");
            e1.ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary ");
            e1.sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Dept Number ");
            e1.deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------Now Printing--------");

            Console.WriteLine(e1.empno);
            Console.WriteLine(e1.ename);
            Console.WriteLine(e1.sal);
            Console.WriteLine(e1.deptno);
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



            int _empno;
            public int empno
            {
                set { _empno = value; }
                get { return _empno; }
            }
            string _ename;
            public string ename
            {
                set { _ename = value; }
                get { return _ename; }
            }
            int _sal;
            public int sal
            {
                set { _sal = value; }
                get { return _sal; }
            }
            int _deptno;
            public int deptno
            {
                set { _deptno = value; }
                get { return _deptno; }
            }
        }
    }
}
