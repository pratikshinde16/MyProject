using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
