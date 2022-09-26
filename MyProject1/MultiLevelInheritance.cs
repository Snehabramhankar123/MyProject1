using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{     //MULTILEVEL INHERITANE //
    class Car
    {
        public string model;
        public string color;
        public int price;
        public void CarInformation()
        {
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price: " + price);
        }
    }
    class Ferrari : Car
    {
        public int speed;

    }
    class Maruti : Ferrari
    {
        float mileage;

        void printmileage()
        {
            Console.WriteLine("Mileage: " + mileage);
        }

        static void Main(string[] args)
        {
            Maruti m = new Maruti();
            m.model = "Alto";
            m.color = "White";
            m.price = 500000;
            m.mileage = 22.5f;
            m.CarInformation();
            m.printmileage();
            Console.ReadLine();

        }
    }
}
    



    
            
    

