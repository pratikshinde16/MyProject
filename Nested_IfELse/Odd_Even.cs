using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Nested_IfELse
{
    class Odd_Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                if (num1>=5 && num1<=10)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Hii Even");
                }

            }
            else if(num1>=2 && num1<=5)
            {
                Console.WriteLine("Hello Odd");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
