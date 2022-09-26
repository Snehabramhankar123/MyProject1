using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
     interface Cake
    {
        void bake();
    }
    class Strawberry :  Cake
    { public  void bake ()
        {
            Console.WriteLine("Baking Strawberry Cake");
        }

    }
    class Blackforest : Cake
    { public void bake()
        {
            Console.WriteLine("Baking Blackforest Cake");
        }
    }
    class Cake1
    {


        static void Main(string[] args)
        {
            Cake c = new Strawberry();
            c.bake();
            Cake c1 = new Blackforest();
            c1.bake();


        }

    }
}
