using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternNumerical
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
}

 
   

   

