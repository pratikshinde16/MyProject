using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class ReverseArrayChar
    {
        public static char[] Reverse(char [] a)
        {
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                char temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            return a;
        }
        static void Main(string[] args)
            
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            char[] arr = new char[size];
            Console.WriteLine("Enter the array character elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",arr));
            char[] r = ReverseArrayChar.Reverse(arr);
            Console.WriteLine("....................");
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
