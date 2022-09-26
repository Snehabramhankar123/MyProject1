using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TwinsNO
    {


        static void Main(string[] args)
        {


            int n1, n2, c1 = 0, c2 = 0;
            Console.WriteLine("Enter the Number");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            for (int i = 2; i < n1 / 2; i++)
            {
                if (n1 % i == 0)
                    c1++;
            }
            for (int i = 2; i < n2 / 2; i++)
            {
                if (n2 % i == 0)
                    c2++;
            }
            int z = Math.Abs(n1 - n2);
            if (c1 == 0 && c2 == 0 && z == z)
                Console.WriteLine("Twin Number");
            else
                Console.WriteLine("Not Twin Number");
        }
    }
}
