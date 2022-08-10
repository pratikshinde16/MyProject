using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{
    class ConstructorChaining
    {
        
        void Person_Info(string Name)
        {
            Console.WriteLine("Name: " + Name);

        }
        void Person_Info(int Age)
        {
            Console.WriteLine("Age: " + Age);
        }
        void Person_Info(float Salary)
        {
            Console.WriteLine("Salary: " + Salary);
        }

        long adhar;
        ConstructorChaining(long adhar)

        { 
           this.adhar =adhar;
            Console.WriteLine("Adhaar Number: "+adhar);
        }
       


        static void Main(string[] args)
        {
            ConstructorChaining c = new ConstructorChaining(830292974545);
            c.Person_Info("Amit");
            c.Person_Info(28);
            c.Person_Info(210000.78f);


        }
    }
}
