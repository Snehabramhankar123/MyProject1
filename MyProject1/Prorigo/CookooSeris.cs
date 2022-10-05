using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class CookooSeries
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(a);
                int c = 1 * b + 2 * a + 3;
                a = b;
                b = c;
            }
            Console.WriteLine(a);
        }
    } 
    class CukooSeries
    {
        public static int Cukoo(int n)
        {
            int a = 0, b = 1, c = 0;
            for(int i=1; i<n; i++)
            {
                c = 1 * b + 2 * a + 3;
                a = b;
                b = c;
            }
            return a;
        }
        static void Main(string[] args)
        { 
            Cukoo(8);
            Console.WriteLine("The Nth term is : " +Cukoo(3) );
               
        }
    }

    
}
