using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Shruti", 123465, 10);
            Employee o2 = new Employee("Shubham", 123465);
            Employee o3 = new Employee("Shivani");
            Employee o4 = new Employee();

            Console.WriteLine("empno = " + o1.EMPNO);
            Console.WriteLine("empno = " + o2.EMPNO);
            Console.WriteLine("empno = " + o3.EMPNO);
            Console.WriteLine("empno = " + o4.EMPNO);

            /*
              Console.WriteLine(o1.NAME + " " + o1.EMPNO + " " + o1.DEPTNO + " " + o1.BASIC);
              Console.WriteLine(o2.NAME + " " + o2.EMPNO + " " + o2.DEPTNO + " " + o2.BASIC);
              Console.WriteLine(o3.NAME + " " + o3.EMPNO + " " + o3.DEPTNO + " " + o3.BASIC);
              Console.WriteLine(o4.NAME + " " + o4.EMPNO + " " + o4.DEPTNO + " " + o4.BASIC);
           */

            Console.ReadLine();

        }
    }

    class Employee
    {
        private static int count;
        private String name;
        private int empNo;
        private decimal basic;
        private short deptNo;

        public Employee()
        {
            empNo = ++count;
            // Console.WriteLine("empno = " + empNo);
        }

        public Employee(String name, decimal basic, short deptno)
        {
            empNo = ++count;
            NAME = name;
            BASIC = basic;
            DEPTNO = deptno;
            //  Console.WriteLine("empno = " + empNo);
        }

        public Employee(String name, decimal basic)
        {
            empNo = ++count;
            NAME = name;
            BASIC = basic;
            // Console.WriteLine("empno = " + empNo);
        }

        public Employee(String name)
        {
            NAME = name;
            empNo = ++count;
            // Console.WriteLine("empno = " + empNo);
        }

        public decimal GetNetSalary()
        {
            return BASIC - BASIC * 5 / 100;
        }

        public String NAME
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Invalid name");
                else
                    name = value;
            }

            get
            {
                return name;
            }
        }

        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        public decimal BASIC
        {
            set
            {
                if (value >= 20000 && value <= 400000)
                    basic = value;

                else
                    Console.WriteLine("Invalid basic");
            }

            get
            {
                return basic;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;

                else
                    Console.WriteLine("Enter Valid Dept. No ");
            }

            get
            {
                return deptNo;
            }
        }

    }
}