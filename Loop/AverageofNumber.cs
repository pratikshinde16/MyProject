using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class AverageofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int num2 = 0;
            while(num1>0)
            {
                int r = num1 % 10;
                sum = sum + r;
                num2 = num2 + 1;
                num1 = num1 / 10;
            }
            int num = sum / num2;
            Console.WriteLine(num);
        }
    }
}
