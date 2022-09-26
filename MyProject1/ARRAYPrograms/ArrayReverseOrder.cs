using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ArrayReverseOrder
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 12, 34, 5, 67, 8, 9, 90 };
            //swap 1with3;
            int start = 0, end = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
               // Console.Write(a[i] + " ");
            }
           int last = a.Length - 1;
            // for (int i=0;i<=a.Length;)
            while (start < end)
            {
                int t = a[start];
                a[start] = a[end];

                a[end] = t;
                start++;
                end--;
            }
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");

            

               

        }
    }
}
