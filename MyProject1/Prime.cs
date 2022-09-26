using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Prime
    {
        public bool isPrime(int a)
        {
            bool isPrime = true;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }


        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());
            Prime p = new Prime();

            bool b = p.isPrime(n);

            if (b == true)
            {
                Console.WriteLine("No is prime");
            }
            else
            {
                Console.WriteLine("No. is not Prime");
            }
            
        }
    }
}
    

