using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class First_que
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("enter the number");
            num1 = int.Parse(Console.ReadLine());
            if (num1>0)
            {
                Console.WriteLine(num1 + "Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
    }
}
