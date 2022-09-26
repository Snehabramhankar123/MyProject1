using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternQuestion
    {
        static void Main(string[] args)
        {
            for( int r=1;r<=5;r++)
            {
                for(int c=r;c>=1;c--)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
}
