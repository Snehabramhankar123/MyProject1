using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class LongestString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String");
            String s = Console.ReadLine();
            string[] sarr = s.Split();
            foreach(char ch in s)
            Console.WriteLine(ch);
            for(int i =0; i< s.Length; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
