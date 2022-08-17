using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SumOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=num;i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
