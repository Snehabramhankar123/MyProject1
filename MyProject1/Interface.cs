using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    interface ICalculator
    {
        void add(int a, int b);
        void subtract(int a, int b);
    }
    interface ScientificCalculator : ICalculator
    {
        void tan(int a);
        void cos(int angle);
    }
    
    /* class ThinkCalculator : ScientificCalculator
     {
        public void add(int a, int b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
         
              public void cos (int angle )
              {
                 Console.WriteLine("Sum= " +Math.Cos(angle));
              }
        public void tan (int angle )
        {
            Console.WriteLine("Sum " +Math.Tan(angle));
        }
     }
    class Demotry
    {
        static void Main(string[] args)
        {
            ICalculator c = new ThinkCalculator();
            c.add(11,12);
            c.subtract(11,12);
          //  c.tan(90);
          //  c.cos(90);


        }
    } */
}



