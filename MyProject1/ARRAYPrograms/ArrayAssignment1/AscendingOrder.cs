using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class AscendingOrder
    {
       
        
            static void Main(string[] args)
            {
                int[] arr = { 12, 3, 45, 67, 34, 21, 89, 5 };
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
                for (int i = 0; i < arr.Length;i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {


                            int t = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = t;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
               




            }
        



    }
}

