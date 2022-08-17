 using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class DivisibleBy3and9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 9 ==0)
            {
                Console.WriteLine("num is Divisible by 3 and 9");
            }
            else 
            {
                Console.WriteLine("num is not Divisible by 3 and 9");

            }

        }
    }
}
