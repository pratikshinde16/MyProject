using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Encapsulation
{
    class Employee
    {
        int eid;
        string ename;
        int basic_salary;
        int pf;
        int total_salary;

        Employee(int eid,string ename,int basic_salary,int pf)
        {
            this.eid = eid;
            this.ename = ename;
            this.basic_salary = basic_salary;
            this.pf = pf;

        }
        Employee() : this(1,"Amit",12000,1800)
        {
            total_salary = basic_salary + pf;
            this.Display();
        }
        void Display()
        {
            Console.WriteLine(eid+" "+ename+" "+basic_salary+" "+pf+" "+total_salary);
        }

        static void Main(string[] args)
        {
            Employee a = new Employee();
        }
    }
}
