using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class CommonArray
    {
        static bool isAlreadyPresent(int[] a, int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (a[i] == a[current])
                    return true;

            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 2, 1, 2 };
            int[] arr2 = { 8, 9, 0, 1, 2, 4 };
           for(int i=0; i< arr1.Length; i++)
            
            {
              if (isAlreadyPresent (arr1,i )==false)
              {
                        int c = 0;
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                            c++;
                    }
                    if(c>0 )
                        Console.WriteLine(arr1[i]);
                    
              }
           }
               
            
        }
    }
}
