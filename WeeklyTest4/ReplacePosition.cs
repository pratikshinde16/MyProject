using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class ReplacePosition
    {
        public static void Replace(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
            }
            
                Console.WriteLine(string.Join(" ",a));
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter the array elements ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(string.Join(" ", arr));
            ReplacePosition r = new ReplacePosition();
            Replace(arr);

        }
    }
}
