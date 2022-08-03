using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Static
{
    class Static_Overloading
    {
        static int Calculator(int a, int b)
        {
            return a + b;
        }
        static int Calculator(float a, int b)
        {
            return (int)a - b;
        }
        static int Calculator(float a, float b)

        {
            return (int)a * (int)b;
        }
        static int Calculator(int a,float b)
        {
            return a/(int)b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Addition is "+Calculator(15,27));
            Console.WriteLine("Substraction is "+Calculator(20f,12));
            Console.WriteLine("Multiplication is "+Calculator(5f,5f));
            Console.WriteLine("Division is "+Calculator(25,5f));

        }
    }
}
