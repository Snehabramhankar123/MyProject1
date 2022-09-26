using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class BInaryToDecimal
    {
        static void BinaryToDecimal()
        {
            int result = 0, r, n, d, i = 1;
            Console.WriteLine("Enter Binary Number");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                d = n % 10;
                r = d * i;
                result = r + result;
                n = n / 10;
                i = i * 2;
            }
            Console.WriteLine("Decimal Equivalent {0} ", result);
        }
            static void Main(string[] args)
            {
               BinaryToDecimal();

            }
        
    }
}
