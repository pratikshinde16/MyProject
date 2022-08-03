using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment
{
    class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void ShowEngine()
        {
            Console.WriteLine(" "+type);
        }


    }

    class Car
    {
        int model_no;
        string cname;
        int price;
        Engine en;

        Car(int model_no, string cname, int price, Engine en)
        {
            this.model_no = model_no;
            this.cname = cname;
            this.price = price;
            this.en = en;
        }
       public void DisplayCar()
        {
            Console.WriteLine(model_no+" "+cname+" "+price);
            en.ShowEngine();

        }
    
        static void Main(string[] args)
        {
            /*  Engine e = new Engine("Petrol");
              Car c;
              c = new Car(100025, "Audi", 7500000, e);*/
            Car c = new Car(100025, "Audi", 7500000, new Engine("Petrol"));
            c.DisplayCar();

        }

    
    }
}
