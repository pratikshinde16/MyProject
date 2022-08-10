using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class Series
    {
        public void Series1(int n)
        {
            //1,3,7,15,31,63,127
            int a = 1;
            for (int i=1;i<=n;i++)
            {
                Console.Write(a+" ");
                a = a * 2 + 1;
            }
        }
        public void Series2(int n)
        {
            //2,3,5,9,17,33,65
            int a = 2;
            for(int i=1;i<=n;i++)
            {
                Console.Write(a + " ");
                a = a * 2 - 1;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            Series s = new Series();
            s.Series1(n);
            Console.WriteLine();
            Console.WriteLine("_________________________");
            Console.WriteLine("Enter the Number");
            int n1 = int.Parse(Console.ReadLine());
            s.Series2(n1);
        }
    }
}
