using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternABBCCC
    {
        static void Main(string[] args)
        {
            
             for(char r='A';r<='H';r++)
            {
                for(char c='A';c<=r;c++)
                {
                    Console.Write(r);
                    

                }
                Console.WriteLine();
            }
        }
    }
}
