using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int lar = 0;
            int small = 9;
            while(n!=0)
            {
                int r = n % 10;
                lar = Math.Max(r, lar);
                small = Math.Min(r, small);
                n = n / 10;
            }

            Console.WriteLine("Largest number= " + lar + "  the smallest= " + small);

                

        }
    }
}
