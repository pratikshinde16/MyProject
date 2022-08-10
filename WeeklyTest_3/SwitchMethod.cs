using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{
    class SwitchMethod
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Country Name :");
            string country = Convert.ToString(Console.ReadLine());

            switch(country)
            {
                case "India": Console.WriteLine("Hockey");
                    break;
                case "China": Console.WriteLine("Tennis");
                    break;
                case "Bangladesh": Console.WriteLine("Kabaddi");
                    break;
                case "Italy": Console.WriteLine("Football");
                    break;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }

    }
}
