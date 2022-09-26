using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class AlternateDiffArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 4, 16, 1, 2, 3, 22 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < c.Length;)
            {
                if (k < a.Length && k < b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                }
                else if (k < b.Length)
                {
                    c[i] = b[k];
                    i++;
                }
                else if (k < a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                k++;
            }
            for (int i = 0; i< c.Length; i++)
            {
                Console.WriteLine(c[i]+" ");
            }
                        

                
            
        }
    }
}
