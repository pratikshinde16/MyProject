using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num1;
            while(num1>0)
            {
                int r = num1 % 10;
                sum = sum + r * r * r;
                num1 = num1 / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }

    }
}
