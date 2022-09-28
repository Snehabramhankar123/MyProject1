using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class ReverseString
    {
        public static string  Reverse(String str)
        {


            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            return rev;
        }

        static void Main(string[] args)
        {
            string s = "My name is Sneha";
            //yM eman si ahenS
            //ahenS si eman yM
            //Sneha is name My
            string[] arr = s.Split();
            foreach(string wrd in arr)
            {
                string r = Reverse(wrd);
                Console.WriteLine(r +" ");
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {




                    // string r = Reverse(wrd);
                    Console.WriteLine(arr);
                }
            }
            foreach(string wrd in arr)
            {
                  Console.WriteLine(wrd);
            }
            for(int i = arr.Length-1; i>=0; i--)
            {
                //Console.WriteLine(wrd);
            }
        }
    }
}
