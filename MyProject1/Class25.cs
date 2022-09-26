using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Class25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            long num = long.Parse(Console.ReadLine());
            long reverse = 0;
            while(num>0)
            {
                long r = num % 10;
                reverse = (reverse * 10) + r;
                num = num / 10;

            }
            Console.WriteLine("The reverse Order is:  " + reverse);
        }
    }
}
