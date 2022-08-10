using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{/*    1
      123
     12345
    1234567                */
    class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=2)
            {
                for (int j = n; j > i; j--)
                    Console.Write(" ");
                for(int k=1;k<=i;k++)
                    Console.Write("{0,2}",k);
                Console.WriteLine();
            }
        }
    }
}
