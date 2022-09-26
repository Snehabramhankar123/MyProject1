using System;
using System.Collections.Generic;

namespace MyProject1
{ 

    class PatternAAAA
    {
        static void Main(string[] args)
        {
            for(char r='A';r<='E';r++  )
            {
                for( int space =1; space<=5; space++)
                {
                    Console.Write(" ");
                }
                for( char c='A'; c<=r; c++ )
                {
                    Console.Write(r);

                }
                Console.WriteLine();  
            }

               
        }
    }
}
