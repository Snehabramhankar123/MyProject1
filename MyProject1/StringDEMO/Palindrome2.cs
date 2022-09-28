using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class Palindrome2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s[i];

            }
            if (reverse == s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
    class FirstOccur
    {
        static void Main(string[] args)
        {
            string s = "sneha";
            int s1 = s.IndexOf('s');
            int s2 = s.IndexOf('n');
            int s3 = s.IndexOf('e');
            int s4 = s.IndexOf('h');
            int s5 = s.IndexOf('a');
            Console.WriteLine(s1);
            Console.WriteLine( s2);
            Console.WriteLine(s3);

            Console.WriteLine(s4);
            Console.WriteLine(s5);







        }

    }
}
    
     
    
   
