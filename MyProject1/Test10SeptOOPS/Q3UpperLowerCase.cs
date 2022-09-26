using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    class Q3UpperLowerCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());
            
            
                if (ch >= 'A' && ch <= 'Z')


              {
                    Console.WriteLine("Upper case Character");
              }
              else if(ch>='a' && ch <='z')
                {
                    Console.WriteLine("Lower case Character");
                }
                else
                {
                Console.WriteLine("Invalid Choice");
                }
            
            
        }
    }
}
