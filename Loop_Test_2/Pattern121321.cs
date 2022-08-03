using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test_2
{
    class Pattern121321
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            for (int i=1;i<=n;i++)
            {
                for (int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }  
    }
}
