using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
             s1 = s1.ToLower();
            s2 = s2.ToLower();
             if(s1.Length != s2.Length)
                Console.WriteLine("Not Anagram");
             char [] c1 = s1 .ToCharArray();
            char[] c2 = s2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string s3 = new string(c1);
            string s4 = new string(c2);
            if(s3==s4)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");



        }
    }
}
