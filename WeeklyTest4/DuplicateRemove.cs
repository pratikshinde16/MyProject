using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class DuplicateRemove
    {
        public static void Duplicate(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                bool ispresent =false;
                for(int j=i-1;j>=0;j--)
                {
                    if(a[i]==a[j])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if(ispresent==true)
                {
                    a[i] = 0;
                }

            }
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array ");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
                Console.WriteLine("Enter the elements in array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            DuplicateRemove.Duplicate(a);
        }
    }
}
