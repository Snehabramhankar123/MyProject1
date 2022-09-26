using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
     class Degree
     {
        public void GetDegree()
        {
            Console.WriteLine("I  got a degree");

        }
     }
    class Undergraduate
    {
        public void GetDegree()
        {
            Console.WriteLine("I am an Undergraduate");
        }

    }
    class Postgraduate
    {
        public void GetDegree()
        {
            Console.WriteLine("I am a Postgraduate");
        }
    }
    class Degree1
    {
        static void Main(string[] args)
        {
            Degree d1 = new Degree();
            Undergraduate u1 = new Undergraduate();
            Postgraduate p1 = new Postgraduate();
            Console.ReadLine();
        }
    }
}
