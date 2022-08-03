using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class Divisible5_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("Number is Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 5 and 11");
            }
        }
    }
}
