using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance
{

    class Animal
    {
        internal string Type = "Omnivorous";
        
    }
    class Tiger:Animal
    {
        internal string Name = "Tiger";
        internal string Food = "Meat";

        public void ShowTiger()
        {
            Console.WriteLine(Type+" "+Name+" "+Food);
        }
        
    }
    class BasicSingleInheritance
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.ShowTiger();
                 
        }
    }
}
