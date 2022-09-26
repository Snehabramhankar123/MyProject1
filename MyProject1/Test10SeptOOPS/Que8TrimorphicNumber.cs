using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    
    
        class Question8TrimorphicNumber
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Number ");
                int num = int.Parse(Console.ReadLine());
                int cube = 1;
                cube = num * num * num;
                int z = cube % 10;
                if (num % 10 == z)
                {
                    Console.WriteLine("Number is Trimorphic");
                }
                else
                {
                    Console.WriteLine("Number is Not Trimorphic ");
                }
            }
        }


    
}
