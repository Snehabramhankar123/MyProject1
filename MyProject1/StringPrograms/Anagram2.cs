using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringPrograms
{
    class Anagram2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 String");
            string s1 = Console.ReadLine().ToLower().Trim();
            string s2 = Console.ReadLine().ToLower().Trim();
            if(s1.Length==s2.Length)
            {
                foreach(char ch  in s1)
                {
                    int idx = s2.IndexOf(ch);
                    if (idx != -1) //idx=2;
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                    Console.WriteLine(s2);
                }
                if (s2.Length == 0)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }

            }
        }
    }
}
