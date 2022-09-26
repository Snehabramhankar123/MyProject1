using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{


    class OverLoad
    {
        public void area(int l, int b)
        {
            int a = l * b;
            Console.WriteLine("Area of Rectangle=" + l * b);
        }
        public void area(int side)
        {
            int area = side * side;
            Console.WriteLine(" Area of Square=" + side * side);
        }
        public void area(float r)
        {
            Console.WriteLine("Area of Circle=" + 3.14 * r * r);
        }
        static void Main(string[] args)
        {
            OverLoad o1 = new OverLoad();
            o1.area(8, 9);
            o1.area(9);
            o1.area(9.4f);
            o1.area(8, 9);
            o1.area(9);
            o1.area(9.4f);
        }
    }
        
}
