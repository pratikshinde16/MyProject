using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class CountOddEven
    {
        public static void Count(int[] a)
        {
            int even = 0;
            int odd = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Even numbers are "+even+" & Total Odd numbers are "+odd);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter the elements of array");
            for (int i=0;i<arr.Length;i++)
            {
                
                arr[i] = int.Parse(Console.ReadLine());

            }
            Count(arr);
        }
    }
}
