using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class PerimeterRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of Rectangle");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of Rectangle");

            float w= float.Parse(Console.ReadLine());

            float p;
            p = 2*(l + w);

            Console.WriteLine("Perimeter of Rectangle is "+p);
            Console.ReadLine();


        }
    }
}
