using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Sumofevennumbers
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            int sum = 0;

            Console.WriteLine("Enter the number");

            num = int.Parse(Console.ReadLine());
                for(i=2;i<=num;i+=2)
            {
                sum += i;

            }


            Console.WriteLine("Sum of Even Numbers is " + num + " = " + sum);

        }
    }
}
