using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class SeperateEvenOdd
    {
        public static void array1(int [] a)
        {
            int[] odd = new int[a.Length];
            int[] even = new int[a.Length];
            int j, k;
            j = 0;
            k = 0;

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    even[j] = a[i];
                    j++;

                }
                else
                {
                    odd[k] = a[i];
                    k++;
                }

            }
            Console.WriteLine("Even array");
            for(int i=0;i<j;i++)
            {
                Console.WriteLine(" "+even[i]);

            }
            Console.WriteLine("Odd array");
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(" "+odd[i]);
            }
        }
        static void Main(string[] args)
        {

            
            SeperateEvenOdd s = new SeperateEvenOdd();
                
        }

    }
}
