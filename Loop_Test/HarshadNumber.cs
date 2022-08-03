using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test
{
    class HarshadNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, a = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;

            }
            if(a%sum==0)
            {
                Console.WriteLine("Harshad Number");

            }
            else
            {
                Console.WriteLine("Not Harshad Number");
            }
        }
    }
}
