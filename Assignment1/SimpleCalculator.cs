using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the Initial char for operation");
            Console.WriteLine("a.Addition\ns.Subtraction\nd.Division\nm.Multiplication");
            
            char ch = Convert.ToChar(Console.ReadLine());
            int a = num1 + num2;
            int s = num1 - num2;
            int d = num1 / num2;
            int m = num1 * num2;
           

            if(ch =='a')
            {
                Console.WriteLine("Addition is "+a);

            }
            else if(ch=='s')
            {
                Console.WriteLine("Subtraction is "+s);
            }
            else if(ch=='d')
            {
                Console.WriteLine("Division is "+d);
            }
            else if(ch=='m')
            {
                Console.WriteLine("Multiplication is "+m);
            }


        }
    }
}
