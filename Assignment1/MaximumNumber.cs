using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class MaximumNumber
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter three numbers");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                if(num1>num2)
                {
                    if(num1>num3)
                    {
                        Console.WriteLine(num1+" is Maximum");
                    }
                    else
                    {
                        Console.WriteLine(num3+" is Maximum");

                    }
                }
                else if(num2>num3)
                {
                    Console.WriteLine(num2 + " is Maximum");
                }
                else
                {
                    Console.WriteLine(num3+" is Maximum");
                }

            }
        }
    }
}
