using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment
{
    class Department
    {
        public int did;
        public string dname;

        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;

        }
        public void ShowDepartment()
        {
            Console.WriteLine(" "+did+" "+dname);
        }

    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department dept;

        Employee(int id, string name, int salary,Department dept)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dept = dept;
        }
    void DisplayEmployee()
        {
            Console.WriteLine(id + " " + name + " " + salary);
            dept.ShowDepartment();

        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1021, "Amit", 120000, new Department(12, "Developer"));
            e.DisplayEmployee();
        }
    }

}
