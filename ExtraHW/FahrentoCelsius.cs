using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class FahrentoCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature to Convert from F to C");
            float f = float.Parse(Console.ReadLine());
            float celsius;
            
            celsius = (f - 32) * 5 / 9;

            Console.WriteLine(celsius+" Celsius");
            Console.ReadLine( );
         




        }
    }
}
