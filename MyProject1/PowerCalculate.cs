using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PowerCalculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= expo; i++)
            {
                power = power * baseNumber;

            }
            Console.WriteLine(power);



                


                
        }
    }
}
