using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Q124SeptSeries5
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 10, 30, 68, 130 };
            for(int i=0; i<=5; i++)
            {
                for(int j=0; j< a.Length; j++)
                {
                    Console.Write(a[j]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
