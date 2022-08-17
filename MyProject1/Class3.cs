using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ClassDigitSymbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }

        }



    }        
         

    
   
 
}