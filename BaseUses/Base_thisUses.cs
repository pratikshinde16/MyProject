using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BaseUses
{
    class Car
    {
        public void Type()
        {
            Console.WriteLine("Sports Car");
        }
            public Car(int numofwheels)
        {
            Console.WriteLine("Number of Wheels: "+numofwheels);
        }
        
         
       
    }

    class Ferrari:Car
    {
        int model_number;
        int topspeed;
         public Ferrari(int model_number, int topspeed):base(8)
        {
            this.model_number = model_number;
            this.topspeed = topspeed;
           
        }
        public void DisplayCar()
        {
            Console.WriteLine(model_number+" "+topspeed);
            base.Type();
        }

    }


    class Base_thisUses
    {
        static void Main(string[] args)
        {
            Ferrari f = new Ferrari(17107, 220);
            f.DisplayCar();
        }

    }
}
