using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Pattern
    {
       static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i%2!=0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write((char)(j+64));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
