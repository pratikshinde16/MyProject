using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class LowerStarTriangle
    {
        static void Main(string[] args)
        {
            char[,] a = new char[5, 5];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        
                        a[i, j] = '*';
                    }
                    else
                    {
                        a[i,j] = ' ';
                    }
                }
                Console.WriteLine();
            }
            
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
