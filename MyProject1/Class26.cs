using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CallByReference
    {
        static public void m1(ref int a, ref int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static public void m2 (int a, int b, out int sum, out int prod )
        {
            sum = a + b;
            prod = a * b;

        }
        static void Main(string[] args)
        {
            int x = 90, y = 890;
            m1(ref x, ref y);
            Console.WriteLine($"x={x}  y= {y}");
            int z = 123;
            int add, mul;
            m2(10, 20, out add, out mul);
            Console.WriteLine(z);

        }
    }
}

