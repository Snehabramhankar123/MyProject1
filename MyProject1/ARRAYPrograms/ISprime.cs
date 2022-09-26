using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ISPrime
    {
        public bool IsPrime(int n)
        {
            for (int i = 0; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            IsPrime i1 = new IsPrime();
            bool b = i1.isPrime(7);
            if (b == true)
                Console.WriteLine("Number is Prime");
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}
