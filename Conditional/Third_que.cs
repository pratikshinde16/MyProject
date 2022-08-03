using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Third_que
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number");
            num1 = int.Parse(Console.ReadLine());
            if (num1>0)
                {
                Console.WriteLine("Number is Positive");
            }
            else if(num1<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }

    }
}
