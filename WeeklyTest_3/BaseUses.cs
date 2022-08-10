using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{
    class Person
    {
        protected string sr_no = ("1240001");
        protected string name = "Kumar";
        
        public virtual void Info()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Sr.No: "+sr_no);

        }
    }
    class Employee:Person
    {
        public string eid = "PQRS1234ZX";
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Employee ID: "+eid);
        }
    }

    class BaseUses
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Info();

        }
    }
}
