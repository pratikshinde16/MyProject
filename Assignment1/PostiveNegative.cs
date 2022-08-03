using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class PostiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            
            if(num>0)
            {
                Console.WriteLine(num+" is Positive Number");
            }
            else if(num<0)
            {
                Console.WriteLine(num+" is Negative Number");
            }
            else if(num==0)
            {
                Console.WriteLine(num+" is Zero");
            }
        }
    }
}
