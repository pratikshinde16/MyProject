using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Car_GetSet
    {
        int model_no;
        string car_name;
        int price;
        int speed;

        public int Model_No
        {
            get
            {
                return model_no;
            }
            set
            {
                model_no = value;
            }
        }

        public string Car_Name
        {
            get
            {
                return car_name;

            }
            set
            {
                car_name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }
class CarDetails
{
    static void Main(string[] args)
    {
                Car_GetSet e = new Car_GetSet();
        e.Model_No = 7450;
        e.Car_Name = "Audi";
        e.Price = 750000;
        e.Speed = 220;

            Console.WriteLine(e.Model_No+" "+e.Car_Name+" "+e.Price+" "+e.Speed);

            
    }
   
}

    
}

