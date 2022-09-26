using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PrimeNumber
    {
public bool IsPrime(int num)
        {
            for(int i=2;i<=num/2;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            PrimeNumber m = new PrimeNumber();
            Console.WriteLine("Enter num");
            int n = int.Parse(Console.ReadLine());
            bool b1 = m.IsPrime(n);
            Console.WriteLine(b1);
                
        }
    }
}
