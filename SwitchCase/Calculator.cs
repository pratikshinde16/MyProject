using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.SwitchCase
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A.Addition\nS.Subtraction\nD.Division\nM.Multiplication");
            Console.WriteLine("Choose the Initial char for operation");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'A': Console.WriteLine("Addition = "+(num1 + num2));
                    break;
                case 'S': Console.WriteLine("Subtraction = " + (num1 - num2));
                    break;
                case 'D': Console.WriteLine("Division = " + (num1 / num2));
                    break;
                case 'M': Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
