using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    class Q9Pattern122233333
    {
        
        
            static void Main(string[] args)
            {
                
                

                for (int r = 1; r <= 4; r++)
                {

                    for (int space = 1; space <= 4 - r; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 1; c <= 2 * r - 1; c++)
                    {
                        Console.Write(r);
                    }
                    Console.WriteLine();
                }

            }
        
    }

}

