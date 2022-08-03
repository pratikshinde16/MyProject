using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class ClassVehicle
    {
        public int model_no;
        public string vehicle_type;
        public int number_of_wheels;
        public int avg;

        public void AcceptDetails(int mn, string vt, int nw)
        {
            model_no = mn;
            vehicle_type = vt;
            number_of_wheels = nw;


        }
        public void Avg()
        {

            if (number_of_wheels == 4 )
            {
                avg = 20;
            }
            else if(number_of_wheels == 8)
            {
                avg = 8;
            }
        }
            public void Display()
        {
            Console.WriteLine(model_no + " " + vehicle_type + " " + number_of_wheels + " " + avg);
        }
                

            
           
            static void Main(string[] args)
            {
                ClassVehicle b = new ClassVehicle();
                b.AcceptDetails(4170, "Car", 4);
                b.Avg();
                b.Display();
            }

        }
    } 
