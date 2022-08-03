using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test_2
{
    class Series0_3_8_15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number of series");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.Write((i*i)-1+",");
            }
        }
    }
}
