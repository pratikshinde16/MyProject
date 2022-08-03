using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class IMEI_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IMEI Number");
            long i = long.Parse(Console.ReadLine());
           
            long sum = 0;


            while (i>0)
            {
                long r = i % 10;
                sum = sum + r;
                i = i / 10;
               

            } if (sum % 10 == 0)
                {
                    Console.WriteLine("Correct IMEI Number");
                }
                else
                {
                    Console.WriteLine("Invalid IMEI Number");
                }

            
            }
        }
    }

