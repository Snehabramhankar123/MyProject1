using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringPrograms
{
    class StringDemo1
    {
        static void Main(string[] args)
        {
            string s = "Thinkquotient";
            string s1 = s.ToUpper();
            string s2 = s.ToLower();
            int idx = s.IndexOf('t');
            int idx1 = s.LastIndexOf('r');
            int idx2 = s.LastIndexOf('o');
            string t = s.Trim();
            string s3 = s.Substring(2);
        }
    }
        class StringDemo
        {


            static void Main(string[] args)
            {


                string s = "Sneha Bramhankar ";
                int i = 2;
                // int s1 = s.ToString(0, i) + s.ToString(i + 1);

            }
        }
    class Split
    {
        static void Main(string[] args)
        {
            string s = "my name is Sakshi";
            char[] arr = s.ToCharArray();
            string[] sarr = s.Split();
            Console.WriteLine(s);
            Console.WriteLine(s);

            string s2 = "Shanaya";
            s2 = s2.Replace('a', 'e');
            Console.WriteLine(s2);
            string str = " red ball red apple red rose";
            str = str.Replace("red", "blue");
            Console.WriteLine(str);
        }
    }
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Other Name");
            string s2 = Console.ReadLine();
            int c = 0;
            for(int i=0; i<s1.Length; i++)
            {
                for(int j=0; j<s2.Length; j++)
                {
                    if (s1.Length == s2.Length && s1[i] == s2[j])
                    {
                        c++;
                    }
                    
                    
                
                    

                    

                }
            }
        }
    }

        
    
}
