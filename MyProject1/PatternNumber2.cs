using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternNumber2
    {
        static void Main(string[] args)
        {
            int lines = 9;
            for(int r=1;r<=lines;r++)
            {
                for(int space=1;space<=lines-r;space++)
                {
                    Console.Write(" ");

                }
                for(int c=1;c<=r;c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }
}
