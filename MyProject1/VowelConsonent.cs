using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class VowelConsonent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;

            }
        }
    }
}
