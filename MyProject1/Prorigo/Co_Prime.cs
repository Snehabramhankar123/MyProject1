using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    
    class CoPrime1
    {
        static int Coprime(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return Coprime(a - b, b);
            else
            return Coprime(a, b - a);
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


        
    
}
