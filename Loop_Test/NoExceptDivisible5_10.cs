using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test
{
    class NoExceptDivisible5_10
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
