using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Cars
    {
        public int model_number;
        public string car_name;
        public int car_price;
        public string car_color;
        
        static void Main(string[] args)
        {
            Cars audi = new Cars();
            audi.car_name = "AUDI";
            audi.model_number = 78945;
            audi.car_price = 7000000;
            audi.car_color = "Black";

        
            Console.WriteLine(audi.car_name + " " + audi.model_number + " " + audi.car_price + " " + audi.car_color);

            Cars bmw = new Cars();
            bmw.car_name = "BMW";
            bmw.model_number = 80045;
            bmw.car_price = 9000000;
            bmw.car_color = "White";

            Console.WriteLine(bmw.car_name + " " + bmw.model_number + " " + bmw.car_price + " " + bmw.car_color);

            Cars volvo = new Cars();
            volvo.car_name = "VOLVO";
            volvo.model_number = 70000;
            volvo.car_price = 8500000;
            volvo.car_color = "Red";

            Console.WriteLine(volvo.car_name + " " + volvo.model_number + " " + volvo.car_price + " " + volvo.car_color);
        }

    }
}
