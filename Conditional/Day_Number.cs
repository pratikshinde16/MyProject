﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Day_Number
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");

            num = int.Parse(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("Monday");

            }
            else if(num==2)
            {
                Console.WriteLine("Tuesday");

            }
            else if(num==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if(num==4)
            {
                Console.WriteLine("Thursday");

            }
            else if(num==5)
            {
                Console.WriteLine("Friday");

            }
            else if(num==6)
            {
                Console.WriteLine("Saturday");

            }
            else
            {
                Console.WriteLine("Sunday");
            }

        }
    }
}
