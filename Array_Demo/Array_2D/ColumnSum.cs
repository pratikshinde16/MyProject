using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class ColumnSum
    {
        public static void SumofCol(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[j, i];
                    Console.WriteLine(a[j,i]+" ");

                }
                Console.Write(" Sum= " + sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            ColumnSum.SumofCol(arr);
        }
    }
}
