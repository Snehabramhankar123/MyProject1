using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class FibboSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            int num3 = num1+ num2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for ( int i=1;i<= n; i++)
           
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                Console.WriteLine(num3);
            }
        }
    }
}
