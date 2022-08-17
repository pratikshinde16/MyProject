using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class AsceDescArray
    {
        public int[] AscDsc(int[] a)
        {
            for (int i=0;i<a.Length;i++)
            {
                for(int j=0;j<(a.Length)/2;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                
                for(int k=((a.Length)/2);k<a.Length;k++)
                {
                    if(a[i]>a[k])
                    {
                        int temp = a[i];
                        a[i] = a[k];
                        a[k] = temp;
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 3, 2, 11, 22, 33, 55, 66 };
            AsceDescArray d = new AsceDescArray();
            int[] asc = d.AscDsc(arr);
            Console.WriteLine(string.Join(" ",asc));
        }
    }
}
