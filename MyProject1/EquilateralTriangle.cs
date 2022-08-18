using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class EquilateralTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length");
            int side = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Area of Equilateral triangle is = " + (1.732 / 4 * side * side)) ;

        }
    }
}
