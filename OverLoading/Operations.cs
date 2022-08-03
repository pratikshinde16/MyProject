using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OverLoading
{
    class Operations
    {
        void Calculate(int x, int y)
        {
            Console.WriteLine("Addition is " + (x + y));
        }
        void Calculate(string Sub, int a, int b)
        {
            Console.WriteLine("Substraction is " + (a - b));
        }
        void Calculate(double c, double d)
        {
            Console.WriteLine("Division is " + (c / d));
        }
        void Calculate(float e, float f)
        {
            Console.WriteLine("Multiplication is" + (e * f));
        }

        static void Main(string[] args)
        {
            Operations c = new Operations();
            c.Calculate(10, 20);
            c.Calculate("sub", 20, 10);
            c.Calculate(10.0f, 20.1f);
            c.Calculate(10, 20.00);

    }
    } }
