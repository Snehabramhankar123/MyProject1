using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Pattern112233
    {
        static void Main(string[] args)
        {
            for(int r=1;r<=5;r++)
            {
                for(int space=2;space<=r;space++ )

                {
                    Console.Write(" ");
                }
                for(int c= 2*r-1;c<=9;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
