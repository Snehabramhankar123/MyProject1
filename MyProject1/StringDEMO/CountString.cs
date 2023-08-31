using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class CountString1
    {
        public static int CountString(string s, string s1)
        {


            int count = 0; int i = 0;
            while ((i = s.IndexOf(s1, i)) != -1)
            {
                i = i + s1.Length;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Name");
            string s = Console.ReadLine();
            for(int i=0; i< s.Length; i++  )
            {
                //CountString(s,s1)
                Console.WriteLine(s);
            }
        }

            
        
    }
}
