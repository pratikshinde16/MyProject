using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test_2
{
    class CalculateXy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Index number: ");
            int y = int.Parse(Console.ReadLine());
            int p = 1;
            while(y>0)
            {
                p = p * x;
                y--;

            }
            Console.WriteLine(p);
        }

    }
}
