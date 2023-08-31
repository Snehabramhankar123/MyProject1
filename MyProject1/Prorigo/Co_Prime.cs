using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    
    class CoPrime1
    { 
         static int Coprime(int a, int b)
         { 
       
            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return Coprime(a - b, b);
            else
                return Coprime(a, b - a);


            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

                
         }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (Coprime (a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }

    }
    class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //row
            {
                for (int j = 1; j <= i; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }

        
    
}
