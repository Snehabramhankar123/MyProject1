using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Uncommon
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 2, 1, 1 };
            int[] b = { 6, 7, 9, 2, 3, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        c++;
                }
                if (c == 0)
                    Console.WriteLine("Uncommon Element " + a[i]);
            }
            for(int i=0; i< b.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                        c++;
                }
                if(c==0)
                    Console.WriteLine("Uncommon Element " + b[i]);
            }
        }
    }
}
