using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class Q6FirstOccurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            string[] arr = s.Split();
            foreach(char ch in s)
                Console.WriteLine(ch);
            int idx = s.IndexOf(s);
            Console.WriteLine(idx);
              

        }
    }
}
