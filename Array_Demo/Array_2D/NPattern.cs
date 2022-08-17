using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo.Array_2D
{
    class NPattern
    {
        public static void Element(char[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (j==0 || j==a.GetUpperBound(1) || i==j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char[,] a = new char[8, 8];
            Element(a);
        }
    }
}
