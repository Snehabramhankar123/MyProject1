using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Sphere
    {


        public  double Volume(double r)
        {
            double volumeofSphere = 4 / 3 * 22 / 7 * r * r * r;
            return volumeofSphere;



        

        }
        public  double Volume(double h, double r)
        {
            double volumeofCylinder = 22/7 * r * r * h;
            return volumeofCylinder;
            
        }
        public double  Volume(double l, double b, double h)
        {
            double volumeofCuboid = l * b * h;
            return volumeofCuboid;
            
        }
        static void Main(string[] args)
        {
             Sphere s1 = new Sphere();
            double d = s1.Volume(5, 6, 8);
            s1.Volume(8);
            s1.Volume(10, 8);
            s1.Volume(8, 9, 10);
            Console.WriteLine(s1.Volume(8));
            Console.WriteLine(s1.Volume(10, 8));
            Console.WriteLine(s1.Volume(8,9,10));
            Console.WriteLine("Volume of spehere is " + d);
           
            

        }
    }


}

