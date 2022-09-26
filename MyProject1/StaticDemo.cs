using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class StaticDemo
    {
        static int c = 20;

        int a = 10;
        public static void m1()
        {
            Console.WriteLine("in static m1");
            m2();
            Console.WriteLine("m1 ends");
         }
        public static void m2()
        {
            Console.WriteLine("in static m2");
            Console.WriteLine(c);
        }
    }
}
