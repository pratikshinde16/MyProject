using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class AverageRow
    {
        public static void AvgRow(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0, c = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    c++;
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine("Average of Row is "+sum/c);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the array Elements ");
            for (int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            AvgRow(a);

        }
    }
}
