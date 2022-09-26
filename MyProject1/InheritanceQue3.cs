using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Person
    {
        int id;
        string name;
        string vehiclev;
        public Person(int id, string name, string vehiclev)
        {
            this.id = id;
            this.name = name;
            this.vehiclev = vehiclev;
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Vehiclev
        {
            set { vehiclev = value; }
            get { return vehiclev; }
        }
    }
    class Vehicle
    {
        int vid;
        string vname;

         public Vehicle(int vid , string vname)
         {
            this.vid = vid;
           this.vname = vname;
         }
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }
        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }
        static void Main(string[] args)
        {
            Person p = new Person(12352, "Sneha", "Car");
            p.Name = "Sneha";
            p.Vehiclev = "Car";
            Vehicle v1 = new Vehicle(12345,"Bullet");
            p.ID = 12352;
            v1.Vid = 5432648;
            v1.Vname = "Abcd";
          // p.Vehiclev=v1;
        }



    } 
}
