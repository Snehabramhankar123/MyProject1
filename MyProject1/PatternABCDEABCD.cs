using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternABCDEABCD
    {
        static void Main(string[] args)
        {
          for( char r='E'; r>='A';r--)
          { 
                for(char c = 'A';c<=r;c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
          }
        }
    }
}
