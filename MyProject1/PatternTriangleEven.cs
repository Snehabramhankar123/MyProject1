using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternTriangleEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Lines");
            int lines = int.Parse(Console.ReadLine());
            int count = 0;
            for(int r=1;r<=lines;r++)
            {
                count++;
                for (int space = 1; space  <= lines - r; space++)
                {
                    Console.Write(" ");
                }
                    for (int c = 1; c <= 2 * r-1; c++)
                    { 
                        Console.Write(" "+count );
                    }
                
                Console.WriteLine();
                

            }
        }
    }
}
