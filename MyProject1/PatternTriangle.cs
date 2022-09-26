using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Lines"); 
            int lines = int.Parse(Console.ReadLine());
            
            for(int r=1; r<=lines;r++)
            {
                
                for(int space=1;space<=lines-r;space++)
                {
                    Console.Write(" ");
                }
                for(int c =1;c<=2*r-1;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
