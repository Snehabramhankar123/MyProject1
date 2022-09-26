using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Pattern123
    {
        static void Main(string[] args)
        {
            for(int r =1; r<=5;r++)
            {
                for(int space=1;space>=r-1;space++)
                {
                    Console.Write(" ");
                }
                    
                for(int c=r;c>=1;c--)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }
}
