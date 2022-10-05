using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.NewFolder1
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s = "omkar";
            String s1 = "omkar";
            Console.WriteLine(s=s1);
            Console.WriteLine(Object.ReferenceEquals(s,s1));
            string s3 = new string("Om");
            string s4 = new string("Om");
            Console.WriteLine(s3==s4);
            Console.WriteLine(Object.ReferenceEquals(s3,s4));
        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            string reverse = "";
            for(int i=s.Length-1; i>=0; i--)
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
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s[i];
            }
            Console.WriteLine(reverse);
        }
    }
    class Size
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < s.Length; i++)

                c++; 

            
            Console.WriteLine(c);
        }
    }
    class Seperate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            int v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    v++;
            }
                Console.WriteLine("Vowels in String are: " +v);
            
        }
    }
    class Toggle
    {
        public void Togle(string s)
        {
          //  Console.WriteLine("Enter the Name");
          //  string ss = Console.ReadLine();
            string charrr = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    charrr = charrr + char.ToLower(s[i]);
                }
                else
                {
                    charrr = charrr + char.ToUpper(s[i]);
                }
            }
            Console.WriteLine(charrr);
        }
        static void Main(string[] args)
        {
            Toggle t1 = new Toggle();
            t1.Togle("DeePAs");
            Console.WriteLine("Enter the Name");
            string ss = Console.ReadLine();
            //  Console.WriteLine( t1.charrr);
        }
        


        
    }
   class Frequency
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            string snew = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    char ch = (char)(s[i] + 32);
                }

                Console.WriteLine(s[i]  +" ");
                Console.WriteLine((char )(s[i]+32));
            }
        }
   }
    
}
