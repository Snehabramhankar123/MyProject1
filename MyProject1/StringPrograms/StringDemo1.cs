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
            string s4 = s.Substring(3, 7);
            Console.WriteLine(s4);
            Console.WriteLine(s3);
            Console.WriteLine(idx);
            Console.WriteLine(idx1);
            Console.WriteLine(t);
        }
    }
        class StringDemo
        {


            //static void Main(string[] args)
            //{


            //    string s = "Sneha Bramhankar ";
            //    int i = 2;
            //     string s1 = s.Substring(0, i) + s.Substring(i + 1);
            //  Console.WriteLine(s1);

            //}
        }
    class Split
    {
        static void Main(string[] args)
        {
            string s = "my name is Sakshi";
            char[] arr = s.ToCharArray();
            //string[] sarr = s.Split();
            Console.WriteLine(s);
            string[] sarr = s.Split();
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
    class Split1
    {
        //static void Main(string[] args)
        //{
        //    string s = "My Name is Sneha";
        //    char[] a = s.ToCharArray();
        //    string[] arr = s.Split();
        //    Console.WriteLine(a);
        //    Console.WriteLine(arr);
        //    string s1 = "Aniket";
        //    s1 = s1.Replace("i", "z");
        //    Console.WriteLine(s1);

        //}
    }
    class Split2
    {
        static void Main(string[] args)
        {
            string s1 = "Ankita";
            s1 = s1.Replace('a', 'e');
            Console.WriteLine(s1);
            Console.WriteLine("Enter tne Name");
            string nm = Console.ReadLine();
            int i = 1;
            string n = nm.Substring(0, i) + nm.Substring(i + 1);
            Console.WriteLine(n);
            char[] a = nm.ToCharArray();
            string[] sa = nm.Split();
            foreach (char ch in a)
                Console.Write(ch);
            Console.WriteLine();
            foreach(string s2 in sa)
                Console.WriteLine(s2);
            Console.WriteLine("Cricket is a Religion in India ");
            string ss = Console.ReadLine();
            string str = ss.Substring(0, 8);
            Console.WriteLine(ss);
        }
    }
    class StringDemo2
    {
        //static void Main(string[] args)
        //{ 
        //  string s = "Cricket is Religion in India";
        //    string s4 = s.Substring(0, 10);
        //    Console.WriteLine(s4);
        //}
    }

        
    
}
