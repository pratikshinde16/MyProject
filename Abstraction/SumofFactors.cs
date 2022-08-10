using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Abstraction
{

    interface IFactorable
    {
        public int Sum(int x);
    }

    class Division:IFactorable
    {
        public int Sum(int x)
        {
            int sum = 0;
            for (int i=1;i<=x; i++)
            {
                if (x%1==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }

    class SumofFactors
    {
        static void Main(string[] args)
        {
            Division d = new Division();
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int a = d.Sum(n);
            Console.WriteLine("Sum of Factor: "+a);
        }

    }
}
