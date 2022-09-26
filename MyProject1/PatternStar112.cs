using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternStar112
    {
        static void Main(string[] args)
        {
            for( int r=1;r<=5;r++)
            {
                for (int c = 1; c <= 2 * r - 1; c++)
                {
                    Console.Write(r);
                }
                
                Console.WriteLine();
            }
        }
    }
}
