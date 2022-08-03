using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Second_que
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine("Number is Divisible by 5");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 5");
            }
        }
    }
}
