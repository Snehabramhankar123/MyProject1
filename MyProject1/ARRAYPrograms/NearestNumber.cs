using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class NearestNumber
    {      

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 34, 56,45, 23 };
            for(int i =0; i< a.Length; i++)
            {
                

                    
            }
               
        }
    }
    class UnCommon
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 2, 1, 1 };
            int[] b = { 1, 6, 7, 9, 2, 3 };
            //4,6,7,9
            for (int i = 0; i < a.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (a[i] == b[j])
                        c++;
                }
                if (c == 0)
                    Console.WriteLine("Uncommon Element " + a[i]);
            }
            for(int i=0; i<b.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                        c++;
                }
                if(c==0)
                    Console.WriteLine("Uncommon Element" +b[i]);

            }


            

        }
    }
}
