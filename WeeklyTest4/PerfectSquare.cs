using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class PerfectSquare
    {
        public static void Square(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=1;j<=a[i]/2;j++)
                {
                    if(a[i]==j*j)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of array");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Square(a);
        }
    }
}
