using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OverLoading
{
    class Calculation
    {
        void Area(int r,double PI)
        {
            Console.WriteLine("Area of Circle"+(PI*r*r));
        }
        void Area(int x,int y)
        {
            Console.WriteLine("Area of Rectangle"+(x*y));
        }
        void Area(float a,float b)
        {
            Console.WriteLine("Area of triangle"+((a*b)/2));
        }
        int Area(int s)
        {
            return s * s;
        }
        static void Main(string[] args)
        {
            Calculation e = new Calculation();
            e.Area(6, 3.4);
            e.Area(8, 7);
            e.Area(7f, 6f);
            int square = e.Area(20);
            Console.WriteLine("Area of Square "+ square);
        }
    }
}
