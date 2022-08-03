using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test
{
    class No1to50_EvenOdd
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i*i);
                }
            }
        }
    }
}
