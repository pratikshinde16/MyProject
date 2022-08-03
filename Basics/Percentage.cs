using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Basics
{
    class Percentage
    {
        static void Main(string[] args)
        {
            int English,Marathi,Hindi,Maths,Science;
            int Total;
            double Percentage;
            English = 45;
            Marathi = 70;
            Hindi = 63;
            Maths = 57;
            Science = 78;

            Total = English + Marathi + Hindi + Maths + Science;
            Percentage = Total / 5;
            Console.WriteLine("Percentage is "+Percentage);
        }
    }
}
