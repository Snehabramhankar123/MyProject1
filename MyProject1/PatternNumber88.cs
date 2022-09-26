using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternNumber88
    {
        static void Main(string[] args)
        {
            for(int r =1;r<=5;r++)
            {
                for(int c=1;c<=r;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
