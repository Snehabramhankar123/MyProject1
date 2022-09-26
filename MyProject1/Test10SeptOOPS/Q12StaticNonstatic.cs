using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    class Static
    {
        public static int a, b;
         public int c;
        public static void Data()
        {
            a = 12;
            b = 23;
           // c = 90;
        }
        public void display()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    class Static1
    {


        static void Main(string[] args)
        {
            Static.Data();
            Console.WriteLine(Static.a);
            Console.WriteLine(Static .b);
          //  Console.WriteLine(Static .c);
            Static s = new Static();

            s.display();
            s.c = 55;
            Console.WriteLine(s.c);
            Console.ReadLine();
        }
    }
    
}
