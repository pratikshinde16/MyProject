using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class Series1
    {

        //Series_1,2,3,3,7,5,15,9,31,17,63,33....
        public void PrintSeries(int n)
        {
            int a = 1;
            int b = 2;
            for (int i=1;i<=n;i++)
            {
                Console.Write(a + " " + b + " ");
                a = a * 2 + 1;
                b = b * 2 - 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            Series1 s = new Series1();
            s.PrintSeries(n);
        }
    }
}
