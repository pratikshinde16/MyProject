using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class Gain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Buying Price of pen");
            float buy = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Selling Price of pen");
            float sell = float.Parse(Console.ReadLine());
            float total;

            total = sell - buy;
            Console.WriteLine("Total gain is "+total+" Rs");
            Console.ReadLine();

        }
    }
}
