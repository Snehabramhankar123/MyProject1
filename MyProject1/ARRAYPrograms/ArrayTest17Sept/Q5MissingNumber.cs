using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayTest17Sept
{
    class MissingNumber
    {
        public int FindMissing(int[] a, int n)
        {
            int total = 1;
            for (int i = 2; i <= (n + 1); i++)
            {
                total = total + i;
                total = total - a[i - 2];

            }
            return total;
        }
         static void Main(string[] args)
         {
            int[] arr = { 1, 2, 3, 4,6,7 };
           // int N = (arr.Length);
             MissingNumber m1 = new MissingNumber();
            m1.FindMissing(arr, arr.Length);
            Console.WriteLine( m1.FindMissing(arr, arr.Length));
         }
    }
}
