using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class SumofElement
    {
        public int element(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] b = new int[10];
                Console.WriteLine("Enter the array elements");
            for (int i=0;i<b.Length;i++)
            {
                b[i] = int.Parse(Console.ReadLine());

            }

            SumofElement c = new SumofElement();
            int sum = c.element(b);
            Console.WriteLine("Total sum of Elements is "+sum);
        }
    }
}
