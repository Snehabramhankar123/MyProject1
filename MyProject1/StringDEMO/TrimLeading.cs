using System;
using System.Collections.Generic;
using System .Text;

            
namespace MyProject1.StringDEMO
{
    class TrimLeading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
                      // string s = "My name is Sneha";
                    string s1 = s.Trim();
            Console.WriteLine();
        }
    }
}
