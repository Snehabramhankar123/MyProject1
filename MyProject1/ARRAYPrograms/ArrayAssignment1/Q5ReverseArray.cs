using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q5ReverseArray
    {
        static void Main(string[] args)
        {
           
            
                int[] a = { 1, 2, 3, 4, 5 };
                int start = 0;
                int end = 4;
                int temp;

                while (start < end)
                {
                    temp = a[start];
                    a[start] = a[end];
                    a[end] = temp;

                    start++;
                    end--;
                }


                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
            
        }
        
    }
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            for(int i= 4 ; i>=0; i--)
            {
                Console.Write( "{0}" + " " ,a[i]);
            }
        }
    }
}
