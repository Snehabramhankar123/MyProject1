using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q1Sum7
    {
        public static void getPairsCount(int[] arr, int sum)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == sum)
                    {
                        count++;
                        


                     Console.WriteLine($"Sum of Pair is :({arr[i]},{arr[j]}) ");
                    }
                }
                
            }
            Console.WriteLine("Count of pairs is " + count);
          
          

            
        }
        static void Main(string[] args)
        {
             int[] arr = {2,4,3,5,6,-2,4,7,8,9 };
           // int[] arr = { 1, 5, 7, -1, 5 };
            int  sum= 7;
              getPairsCount(arr, sum);
            Console.WriteLine();
        }

        
    }
}
