using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class DivisibleBy3_9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i%3==0 && i%9==0)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
        
    }
}
