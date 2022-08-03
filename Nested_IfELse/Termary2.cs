using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nested_IfELse
{
    class Termary2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Num");
            int num1 = int.Parse(Console.ReadLine());
            string num2 = num1 > 0 ? "Number is Postive" : num1 < 0 ? "Number is Negative" : "Number is Zero";
            Console.WriteLine(num2);
        }
    }
}
