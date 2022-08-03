using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test
{
    class Happy_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            bool flag = true;
            while(num>0)
            {
                int r = num % 10;
                if(r%2==0)
                {
                    flag = false;
                    break;
                }
                num = num / 10;
            }
            if(flag==true)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }

        }
    }
}
