using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = 1001001;
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
                Console.WriteLine("Binary Number " + binVal );
                Console.WriteLine("\n Decimal: "+decVal);
                Console.ReadLine();
            
        }
    }
    class DecimalToBinary1
    {
        static void Main(string[] args)
        {
            // int num;
            int sum = 0;  int i = 0;
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
             //  sum += (num % 10) * Math.Power(2, i);
                num = num / 10;
                i++;
            }
            Console.WriteLine();
            
        }
    }
}
