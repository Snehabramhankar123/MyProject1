using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PrimeNotPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i=2; i<num; i++)
            {
                if ( num % i == 0)
                {
                    isPrime = false;
                }
            }
                 if (isPrime==true)
            {
                Console.WriteLine("Prime");

            }
            else
            {
                Console.WriteLine(" not prime");
            }

        }
    }
}
