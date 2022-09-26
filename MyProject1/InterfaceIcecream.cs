using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    interface Icecream
    {
        void eat();
    }
    interface Juice
    {
        void drink();
    }
    class Mastani : Icecream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Eating Ice-Cream...... ");

        }
        public void drink()
        {
            Console.WriteLine("Drinking Juice .......");
        }
    }
        class Icecream1
        {


            static void Main(string[] args)
            {
             Icecream m1 = new Mastani ();
             m1.eat();
             Juice m2 = new Mastani ();
             m2.drink();
            Mastani m = new Mastani();
            m.eat();
            m.drink();
            }
        }

    
}
