using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class MinfreChar
    {
        public static void Count(char[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int c = 1;
                bool ispresent = true;
                for(int j=i-1;j>=0;j--)
                {
                    if(a[i]==a[j])
                    {
                        ispresent = false;
                        break;
                    }

                }
                if(ispresent==true)
                {
                    for(int k=i+1;k<a.Length;k++)
                    {
                        if(a[i]==a[k])
                        {
                            c++;
                        }
                    }
                    if(c==1)
                    {
                        Console.WriteLine("Min Frequency char is "+a[i]);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size ");
            int s = int.Parse(Console.ReadLine());
            char[] a= new char[s];
            for(int i=0;i<a.Length;i++)

            {
                Console.WriteLine("Enter the char array ");
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            Count(a);
        }
    }
}
