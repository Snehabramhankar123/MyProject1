using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class MergeArrayAlternate
    {
        static void Main(string[] args)
        {

            int[] a = new int[5]; ;
            int[] b = new int[5];
            int[] c = new int[10];
            Console.WriteLine("Elements of Array a");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements of Array b");

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Copying elements of array a and b to c in alternate manner");
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k = k + 2;
            }
            k = 1;
            for (int j = 0; j < b.Length; j++)
            {
                c[k] = b[j];
                k = k + 2;
            }

            /* int[] merg = new int[a[i] + a[j]];
           // int  b = 0;
             for (int i = 0; i < merg.Length; i++)
             {
                 if (i < a.Length && i < b.Length)
                 {
                     merg[nc] = neg[i];
                     nc++;
                     merg[nc] = other[i];
                     nc++;
                 }
                 else if (i < other.Length)
                 {
                     merg[nc] = other[i];
                     nc++;
                 }
                 else if (i < neg.Length)
                 {
                     merg[nc] = neg[i];
                     nc++;
                 }
             }


             Print<int>.MyArray(merg);

         } // Print<int>.MyArray(merg);
         static void Main(string[] args)
         {
             int[] a = { 1, 2, 3, 4, 5, 6, -1, -2, -3, -4, -5, -6 };
             PosNeg(a);
         } */









        }

    }
}
