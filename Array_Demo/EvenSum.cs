using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class EvenSum
    {
        public int Evensum(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    sum = sum + a[i];

                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array elements ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            EvenSum e = new EvenSum();
            int sum = e.Evensum(arr);
            Console.WriteLine("Sum of even elements: "+sum);

        }
        
    }
}
