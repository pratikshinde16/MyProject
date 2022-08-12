using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Practice001
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c;
            for(int i=0;i<=15;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
