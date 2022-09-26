using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q9evenODD
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            int i, j = 0, k=0 ,n;
            //Console.Write("Separate Even and Odd Integers");
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
            for(i=0; i<n; i++)
            {
                
                
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    k++;
                }
            }
            for( i=0; i < j; i++)
            {
                Console.WriteLine("{0}",b[i]);
            }
            Console.Write( " ");
            for(i=0; i<k; i++)
            {
                Console.WriteLine("{0}", c[i] );
                Console.WriteLine();

            }
                
            


        }
    }
}
