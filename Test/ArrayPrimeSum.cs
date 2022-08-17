using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    class ArrayPrimeSum
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                bool isprime = true;
                for(int j=2;j<a[i];j++)
                {
                    if(a[i]%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
