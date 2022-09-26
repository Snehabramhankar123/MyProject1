using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class PosNeg1
    {
        static class Print<t>
        {
            public static void MyArray(t[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(" " + a[i]);
                }
            }
        }
        static void PosNeg(int[] a)
        {
            int pc = 0, nc = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    pc++;
                }
                else
                {
                    nc++;
                }
            }
            int[] neg = new int[nc];
            int[] other = new int[pc];
            nc = 0;
            pc = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    other[pc] = a[i];
                    pc++;
                }
                else
                {
                    neg[nc] = a[i];
                    nc++;
                }
            }
            int[] merg = new int[pc + nc];
            nc = 0;
            for (int i = 0; i < merg.Length; i++)
            {
                if (i < other.Length && i < neg.Length)
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
           
        }
       // Print<int>.MyArray(merg);
        
    }
    
}
    