using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class FrequencyFind
    {
        public int frequency(int[]a,int b)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 4, 2, 6, 7, 2, 4, 3, 2, 1, 3, 1, 2, 1, 1 };
            Console.WriteLine("Given array is ");
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine("                                ");
            Console.WriteLine("Enter the element ");
            int num = int.Parse(Console.ReadLine());
            FrequencyFind f = new FrequencyFind();
            int fr = f.frequency(arr, num);
            Console.Write("Frequency of " + num + " is " + fr);

        }


    }
}
