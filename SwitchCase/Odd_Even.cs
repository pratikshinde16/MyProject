using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.SwitchCase
{
    class Odd_Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            switch(num%2)
            {
                case 0: Console.WriteLine("Number is Even");
                        break;
                case 1: Console.WriteLine("Number is Odd");
                    break;
            }
        }
    }
}
