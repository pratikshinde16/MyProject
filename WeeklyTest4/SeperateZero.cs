using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class SeperateZero
    {
        public static int[] Zero(int[] a)
        {
            for(int i=0;i<a.Length; i++)
            {
                for(int j=0;j<a.Length-1;j++)
                {
                    if(a[j]==0)
                    {
                        a[j] = a[j + 1];
                        a[j + 1] = 0;

                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter the array elements");
            for (int i=0;i<a.Length;i++)
            {
                
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = SeperateZero.Zero(a);
            Console.WriteLine(string.Join( " ",a));
        }
    }
}
