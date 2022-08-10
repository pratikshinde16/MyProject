using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class CountOddElements
    {
        public int Odd(int[] a)
        {
            int b = 0;
            for(int i=0; i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    b++;
                }
            }
            return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine("Enter the number:");
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOddElements c = new CountOddElements();
            Console.WriteLine("Total odd elements are: "+c.Odd(a));
        }
    }
}
