using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance
{
    class Food
    {
        protected string Taste = "Spicy";

    }

    class Fastfood:Food
    {
        internal string Chinese = "Noodles";
        internal string Effect = "Unhealthy";
        
        public void ShowFastfood()
        {
            Console.WriteLine(Chinese+" "+Effect+" "+Taste);
        }
    }
    class Nutritionalfood:Food
    {
        internal string Vegetable = "Green Vegetables";
        internal string Effect = "Healthy";
        
        public void ShowNutritionalfood()
        {
            Taste="Less_Spicy";
            Console.WriteLine(Vegetable+" "+Effect+" "+Taste);
        }
    }
    class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            Fastfood f = new Fastfood();
            f.ShowFastfood();
            Nutritionalfood n = new Nutritionalfood();
            n.ShowNutritionalfood();
        }
    }
}
