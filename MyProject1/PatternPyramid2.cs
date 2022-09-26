using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternPyramid2
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int space = 2; space <= r; space++)
                {
                    Console.Write(" ");
                }
                for (int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
               
            

        }
    }
}
