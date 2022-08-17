using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            int radius;
            double PI, area;
            PI = 3.14;
            radius = 8;
            area = PI * radius * radius;
            Console.WriteLine("Area of circle=" + area);
        }
    }
}
