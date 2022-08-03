using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test
{
    class KrishnaMurthyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int num = 0;
            while(n>0)
            {
                int r = n % 10;
                int sum = 1;
                for(int i=1;i<=r;i++)
                {
                    sum = sum * i;
                }
                num = num + sum;
                n = n / 10;

            }
            Console.WriteLine(num);
            if(num==a)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy Number");
            }
        }
    }
}
