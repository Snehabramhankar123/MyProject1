using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{   /*  static class MyArray<T>
   {
        public static void Print(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(" " + arr[i]);
            }
        }
    }*/
    class AlternatePosNeg
    {
        static class MyArray<T>
        {
            public static void Print(T[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    Console.Write(" " + arr[i]);
                }
            }
        }
            static void Main(string[] args)
        {
            int[] arr = { 12, 4, 5, -3, -5, 90, 80, 70, -12 };
            int[] b = new int[arr.Length];
            int p = 0, n = 0;
            int k = 0;//to track new array
            while (k < arr.Length)
            {
                while (p < arr.Length && arr[p] < 0)
                {
                    p++;
                }
                if (p < arr.Length)
                {
                    b[k] = arr[p];
                    k++;
                    p++;
                }
                while (n < arr.Length && arr[n] > 0)
                {
                    n++;
                }
                if (n < arr.Length)
                {
                    b[k] = arr[n];
                    k++;
                    n++;
                }
            }
            int[] merg = new int[p + n];
            n = 0;
            for (int i = 0; i < merg.Length; i++)
            {
               /* if (i < other.Length && i < n.Length)
                {
                    merg[n] = n[i];
                    n++;
                    merg[n] = other[i];
                    n++;
                }
                else if (i < other.Length)
                {
                    merg[nc] = other[i];
                    nc++;
                }
                else if (i < neg.Length)
                {
                    merg[n] = n[i];
                    n++;
                } */
            }
            // MyArray<int>.Print(arr);
            // MyArray<int>.Print(arr);
            //   for (int i = 0; i < arr.Length; i++)
            //   {

            // Console.Write(" " + arr[i]);
            //   }
            //   }

        }

    }


}


