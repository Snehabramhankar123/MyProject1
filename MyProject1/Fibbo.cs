using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Fibbo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NTH Term");
            int n = int.Parse(Console.ReadLine());
            int a = 0; int b = 1;
            int c = a + b;

            for (int i = 1; i < n; i++)
            {

                a = b;

                b = c;
                c = a + b;
            }
            Console.WriteLine(a);


        }
    }
    class COprime
    {
        static bool isCoprime(int a, int b)
        {
            int gcd = 1;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            if (gcd == 1)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n1 = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 1; i < n1; i++)
            {
                if (isCoprime(i, n1))
                {
                    Console.WriteLine($"Coprime Pair ({i},{n1})");
                    c++;
                }
               
                
            }
              
            Console.WriteLine("No. of pairs is " +c);

        }


    }
}

