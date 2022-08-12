using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Patterns
{
    class StarPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Pattern---------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.WriteLine("2nd Pattern---------------");
               

            for(int i=1;i<=5;i++)
            {
                for(int j=i;j<=4;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
           
            Console.WriteLine("3rd Pattern--------------------");




            




            
            
        }
    }
}
