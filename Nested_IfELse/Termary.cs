using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nested_IfELse
{
   class Termary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Num");
            int n = int.Parse(Console.ReadLine());

            string num = n%2==0? "Number is Even" : "Number is Odd";
            Console.WriteLine(num);

        }
    }
}
