using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Nested_loop
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for (int j = 1; j <= 3; j++) 
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
