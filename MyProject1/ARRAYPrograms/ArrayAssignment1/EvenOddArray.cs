
        
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class EvenOddArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 55, 66, 77, 88, 9, 31 };
            int e = 0, o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    e++;
                else
                    o++;
            }
            int[] even = new int[e];
            int[] odd = new int[o];
            e = 0;
            o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] % 2 == 0)
                    {
                        even[e] = arr[i];
                        e++;
                    }
                    else
                    {
                        odd[o] = arr[i];
                        o++;
                    }
                }


                Console.WriteLine(arr[i] + " ");

                Console.WriteLine(even[e]);
                Console.WriteLine(odd[o]);
            }



        }
              
                        


            


        
    }
}
