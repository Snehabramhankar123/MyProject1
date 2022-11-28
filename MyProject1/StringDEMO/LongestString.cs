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
            int[] a = { 1, 2, 55, 23, 45 };
            int max = a[0];
            int min = a[0];
            for(int i=0; i<5; i++)
            {
                if (max < a[i])
                    max = a[i];
                if (min > a[i])
                    min = a[i];
            }
          
        }
    }
}
