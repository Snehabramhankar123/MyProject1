using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.StringDemo
{
    class StringAssignment1Q1
    {
        static void Main(string[] args)
        {


            string s = "Sneha is in Nagpur";
            string s1 = s.ToLower();
            char [] arr = s.ToCharArray();
            string [] s2 = s.Split();
            Console.WriteLine(arr);
            Console.WriteLine(s1);
            foreach (char ch in s) 
            Console.WriteLine(ch);
            foreach (char ch in s)
           Console.WriteLine(ch);


        }

    }
}
