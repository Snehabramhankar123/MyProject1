using System;
using System.Collections.Generic;
using System.Text;  //If a class contain  multiple constructor where  each type of constructor 
// have diffrent  parameters list is calles Constructor OverLoading.

namespace MyProject1.Test10SeptOOPS
{
    class Constructor
    {
        public Constructor ()
        {
            Console.WriteLine("This is First Constructor");
        }
        public Constructor(int a  ,int b)
        {
            Console.WriteLine("This is a Second Constructor" +(a+b));
        }
        public Constructor (int a ,int b, int c)
        {
            Console.WriteLine("This is a Third Constructor " +(a+b+c));
        }
        static void Main(string[] args)
        { 
             Constructor c1 = new Constructor(20,40);
            Console.ReadLine();
        }

           

            


    }
}
