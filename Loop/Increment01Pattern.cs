﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Increment01Pattern
    {
        static void Main(string[] args)
        {
         
            for(int i=1;i<=4;i++)
            {
                for(int j=0; j<i;j++)
                {
                    Console.Write((j + i) % 2);
                }
                Console.WriteLine();
            }
        }
    }
}
