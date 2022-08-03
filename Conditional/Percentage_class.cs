using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Percentage_class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the five subject marks");
            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int sub4 = int.Parse(Console.ReadLine());
            int sub5 = int.Parse(Console.ReadLine());
            int Total = sub1 + sub2 + sub3 + sub4 + sub5;
            Console.WriteLine("Total " + Total);
            int Percentage = Total / 5;
            Console.WriteLine("Percentage is " + Percentage);
            if(Percentage >= 70)
            {
                Console.WriteLine("Distinction");
            }
            else if(Percentage >= 60 && Percentage < 70) 
            {
                Console.WriteLine("First Class");
            }

            else if (Percentage >= 50 && Percentage < 60) 
            {
                Console.WriteLine("Second Class");
            }


            else if (Percentage >= 35 && Percentage < 50) 
            {
                Console.WriteLine("Pass Class");

            }
            else 
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
