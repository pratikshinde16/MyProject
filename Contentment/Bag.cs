using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment
{
    class Pen
    {
        int length;
        string penname;
        string color;
        string type;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string PenName
        {
            get { return penname; }
            set { penname = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
    }
    class Bag
    {
        string bname;
        int price;
        string color;
        Pen p;

        public string BName
        {
            get { return bname; }
            set { bname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }

    }
    class BagInfo
    {
        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.BName = "Wildcraft";
            b.Price = 2200;
            b.Color = "Black";
            b.P = new Pen();
            b.P.Length = 15;
            b.P.PenName = "Parker";
            b.P.Color = "Blue";
            b.P.Type = "Ball_Pen";

            Console.WriteLine(b.BName+" "+b.Price+" "+b.Color+" "+"Pen "+b.P.Length+" "+b.P.PenName+" "+b.P.Color+" "+b.P.Type);
        }
    }

}
