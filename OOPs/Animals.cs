using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Animals
    { 
   
    public string animal_name;
    public int number_of_legs;
    public string food_type;

        static void Main(string[] args)
        {
            Animals tiger = new Animals();
            tiger.animal_name = "Tiger";
            tiger.number_of_legs = 4;
            tiger.food_type = "Meat";

            Console.WriteLine(tiger.animal_name+" "+ tiger.number_of_legs+" "+ tiger.food_type);

            Animals cow = new Animals();
            cow.animal_name = "Cow";
            cow.number_of_legs = 4;
            cow.food_type = "Grass";

            Console.WriteLine(cow.animal_name+" "+cow.number_of_legs+" "+cow.food_type);

        }
    
    }
}
