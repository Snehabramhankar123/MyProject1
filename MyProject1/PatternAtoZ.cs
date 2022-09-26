using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternAtoZ
    {
        static void Main(string[] args)
        {
            char count = 'A';
            for (char r = 'A'; r <= 'G'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    

                    Console.Write(count);
                    count++;

                }
                Console.WriteLine();
            }

        }
    }
}
