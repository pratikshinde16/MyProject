using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test_2
{
    class Pattern110101
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of series to display");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                for(int j=1;j<=n+1-i;j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
