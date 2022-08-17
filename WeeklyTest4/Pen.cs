using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class Pen
    {
        Refill r;
        float CapLength;
        string brand;
        public Refill R
        {
            set;
            get;
        }
        public float Clength
        {
            set;
            get;
        }
        public string Brand
        {
            set;
            get;
        }
    }
    class Refill
    {
        string inkcolor;
        float length;
        Nib n;
        public string Inkcolor
        {
            set;
            get;
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib N
        {
            get;
            set;
        }
    }
    class Nib
    {
        string mtype;
        double width;
        public string Mtype
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
        }
    }
    class Display
    {


        static void Main(string[] args)
        {
            Pen P = new Pen();
            P.Clength = 4;
            P.Brand = "Reynold";
            P.R = new Refill();
            P.R.Inkcolor = "Blue";
            P.R.Length = 10;
            P.R.N = new Nib();
            P.R.N.Mtype = "Strong";
            P.R.N.Width = 0.5;

            Console.WriteLine(P.Clength + " " + P.Brand + " " + P.R.Inkcolor + " " + P.R.Length + " " + P.R.N.Mtype + " " + P.R.N.Width);
        }

    }
}
