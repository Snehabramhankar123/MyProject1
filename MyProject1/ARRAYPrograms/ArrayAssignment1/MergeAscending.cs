using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class MergeAscending
    {
        static void Main(string[] args)
        {
            int n, i, j = 0,  lrg, lrg2nd;
            int[] arr1 = new int[50];
            Console.WriteLine("Input the size of Array");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element -{0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            lrg = 0;
            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            lrg2nd = 0;
            for(i=0; i< n; i++)
            {
                if(i==j)
                {

                }
            }
        }
    }
}
