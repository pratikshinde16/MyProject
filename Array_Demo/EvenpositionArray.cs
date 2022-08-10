using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class EvenpositionArray
    {
        public void even(int []arr)
        {
            Console.WriteLine("......Even Position in Array......");
            for(int i=0;i<arr.Length;i++)
            {
                if(i==0||i%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter Array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            EvenpositionArray e = new EvenpositionArray();
            e.even(a);
        }
    }
}
