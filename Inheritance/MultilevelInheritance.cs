using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance
{

    class Footwear
    {
        internal string Type = "Shoes";

        public void ShowFootwear()
        {
            Console.WriteLine(Type);
        }
    }

    class Make:Footwear
    {
        internal string Style = "American";
        internal string Color = "Black";
        public void ShowMadeIn()
        {
            Console.WriteLine(Type+" "+Style+" "+Color);
        }
    }
     class Size:Make
    {
        internal int Number = 8;
        public void ShowSize()
        {
            Console.WriteLine(Type+" "+Style+" "+Color+" " +Number);
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Size s = new Size();
            s.ShowFootwear();
            s.ShowMadeIn();
            s.ShowSize();
            

        }
    }
}
