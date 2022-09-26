using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternNumber11
    {
        static void Main(string[] args)
        {
            for( int r=1; r<=9;r++)
            {
                for (int space = 1; space <= 9; space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                
                Console.WriteLine( );
            }
        }
    }
}
