using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class Addition2D
    {
        static void Main(string[] args)
        {
            int[,] a = { { 4, 6 }, { 7, 3 } };
            int[,] b = { { 2, 5 }, { 8, 4 } };

            int[,] c = new int[2, 2];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            for(int i=0;i<c.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(c[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
