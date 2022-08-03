using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nested_IfELse
{
    class Blood_Donation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            int weight = int.Parse(Console.ReadLine());

            if(age>18)
            {
                if(weight>50)
                {
                    Console.WriteLine("Eligible for Blood Donation");
                }
                else
                {
                    Console.WriteLine("Not Eligible for Blood DOnation");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible for Blood Donation");
            }
        }
    }

}
