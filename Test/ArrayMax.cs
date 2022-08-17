using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    class ArrayMax
    {
        public static int Max(int[] arr)
        {
            int m = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>m)
                {
                    m = arr[i];
                }
            }
            return m;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ArrayMax.Max(arr));
        }
    }


}
