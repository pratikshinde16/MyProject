using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    class ContinuousInput
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int num = int.Parse(Console.ReadLine());
                if(num==0)
                {
                    Console.WriteLine("You Entered Zero");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter another number");
                }

            }
        }
    }
}
