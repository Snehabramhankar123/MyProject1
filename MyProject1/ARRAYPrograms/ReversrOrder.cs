using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ReverseOrder
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, 45, 66, 9 };
            int n = a.Length;
            int start = 0, end = n - 1;
            while (start < end)
            {
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;
            }
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }

        
    }
}
