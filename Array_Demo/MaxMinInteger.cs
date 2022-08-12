using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class MaxMinInteger
    {
        public void MaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            for(int i=0;i<a.Length;i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }

            }
            Console.WriteLine("Maximum Number is "+max);

            for(int i=0;i<a.Length;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum Number is "+min);
        }
        static void Main(string[] args)
        {
            int[] b = new int[6];
            for(int i=0;i<b.Length;i++)
            {
                b[i] = int.Parse(Console.ReadLine());

            }
            MaxMinInteger m = new MaxMinInteger();
            m.MaxMin(b);

        }
    }
}
