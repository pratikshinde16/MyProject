using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int i = int.Parse(Console.ReadLine());
            int fact=1;
            for(int num=1;num<=i;num++)
            {
                fact = fact * num;

            }
            Console.WriteLine(fact);
        }
    }
}
