using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class SparseCheck
    {
        public static void Sparse(int[,] a)
        {


            int d = 0;
            int e = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]!=0)
                    {
                        d++;
                    }
                    else
                    {
                        e++;
                    }
                }
            }
            if(e>d)
            {
                Console.WriteLine("Sparse Matrix");
            }
            else
            {
                Console.WriteLine("Not Sparse Matrix");
            }


        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter the array elements");
            for (int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Sparse(a);
        }
    }
}
