using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class CoPrime12
    {
        static bool isCoprime(int a, int b)
        { int gcd = 1;
            for(int i=0; i<=a && i>=b; i++)
            {
                if(a%i==0 && b%i == 0)
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
            Console.WriteLine("Enter the Number");
            int n1 = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < n1; i++)
            {
                if (isCoprime(i, n1))
                {
                    Console.WriteLine($"The Coprime Pair is:({i},{n1})");
                    c++;
                }
            }
            Console.WriteLine("The no. of Pair is:" +c);

            
            
        }
    }
}
