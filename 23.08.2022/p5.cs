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
          Employee[]  Employees = new Employee[2];
            for (int i = 0; i < 2 ; i++)
            {
                
                Console.WriteLine("Enter Employee Number");
                int empno =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                int sal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Department Number");
                int deptno = Convert.ToInt32(Console.ReadLine());
                Employees[i].Acceptdata(empno, ename, sal, deptno);
            }
            for (int i = 0; i < 2; i++)
            {
                Employees[i].Display();
                Console.WriteLine("------------------------------------------------");
               
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

namespace _23._08._2022
{
    class Class2
    {
      struct Employee
    {
        int _empno;
        string _ename;
        int _sal;
        int _deptno;

        public void Acceptdata(int empno, string ename, int sal, int deptno)
        {
            this._empno = empno;
            this._ename = ename;
            this._sal = sal;
            this._deptno = deptno;
        }
        public void Display()
        {
            Console.WriteLine(_empno);
            Console.WriteLine(_ename);
            Console.WriteLine(_sal);
            Console.WriteLine(_deptno);
        }
    }
}

