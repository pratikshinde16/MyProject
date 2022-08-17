using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class MaxMinRow
    {
        public static void RowMax(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[0, i];
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j] )
                    {
                        max = a[i, j];
                       
                    }
                    Console.Write(a[i, j] + " ");

                }
                Console.Write("Row Max= "+max );
                Console.WriteLine();
            }
        } 
        public static void RowMin(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                
                int min = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ( min > a[i, j])
                    {
                        
                        min = a[i, j];
                    }
                    Console.Write(a[i, j] + " ");

                }
                Console.Write("Row Min= "+min );
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 7, 8, 9}, { 4, 5, 6 }, { 1, 2, 3 } };
            MaxMinRow.RowMax(arr);
            MaxMinRow.RowMin(arr);
        }
    }
}
