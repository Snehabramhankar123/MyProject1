
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PositiveNegative
    { 

        static void Main(string[] args)
        { 

         
             Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("number is positive");
            }
            else if(num<0)
            {
                Console.WriteLine("number is negative ");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }
        
    }
}
