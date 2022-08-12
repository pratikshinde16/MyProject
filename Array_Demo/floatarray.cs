using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class floatarray
    {
        static void Main(string[] args)
        {
            
            float[] a = new float[5];
            

            Console.WriteLine("Enter the array Elements ");
            for(int i=0;i<a.Length;i++)
            {
                
               a[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Display using for.......");

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

            
            Console.WriteLine("Display using foreach.........");
            foreach(float x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Display Using join............ ");

            Console.Write(string.Join(" ",a));


        }
    }
}
