using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest4
{
    class Car
    {
        int carid;
        string carcolor;
        Engine en;
        SubEngine s;
        Gear g;
        public int CarId
        {
            get { return carid; }
            set { carid = value; }
        }
        public string CarColor
        {
            get { return carcolor; }
            set { carcolor = value; }
        }
        public Engine En
        {
            get { return en; }
            set { en = value; }
        }
        public SubEngine S
        {
            get { return s; }
            set { s = value; }
        }
        public Gear G
        {
            get { return g; }
            set { g = value; }
        }

    }
    class Engine
    {
        int engineid;
        string Lastenginecleandate;

        public int EngineId
        {
            get { return engineid; }
            set { engineid = value; }
        }
        public string lastenginecleandate
        {
            get { return Lastenginecleandate; }
            set { Lastenginecleandate = value; }
        }

    }
    class SubEngine
    {
        string SubType;
        public string Subtype
        {
            get { return SubType; }
            set { SubType = value; }

        }
    }
    class Gear
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.CarId = 7894561;
            c.CarColor = "White";
            c.En = new Engine();
            c.En.EngineId = 700;
            c.En.lastenginecleandate = "14/03/2022";
            c.S = new SubEngine();
            c.S.Subtype = "Diesel";
            c.G = new Gear();
            c.G.Type = "Auto";

            Console.WriteLine(c.CarId+" \n "+ c.CarColor+" \n "+c.En.EngineId+" \n "+c.En.lastenginecleandate+" \n "+ c.S.Subtype+" \n "+ c.G.Type);
        }
    }
}
