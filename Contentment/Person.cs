using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment
{
    class Address
    {
        int pincode;
        string city;
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    
    class Person
    {
        int id;
        string name;
        Address adr;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }
    }
    class PersonInfo
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 510;
            p.Name = "Rohan";
            p.Adr = new Address();
            p.Adr.Pincode = 410504;
            p.Adr.City = "Mumbai";

            Console.WriteLine(p.Id+" "+p.Name+" "+p.Adr.Pincode+" "+p.Adr.City );


        }
    }
    
}
