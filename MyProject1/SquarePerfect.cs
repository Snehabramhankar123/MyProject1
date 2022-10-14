using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SquarePerfect
    {



        static void countSquares(int[] arr)
        {

            int count = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                int square = arr[i] * arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == square)
                    {
                        count++;
                    
                      Console.WriteLine(count);
                      Console.WriteLine($"The Perfect Square number is : " +arr[j]);
                    }
        
    
                }
            }


        }
    
        
    
            
            static void Main(string[] args)
            {
                int[] arr = { 2, 4,100, 64, 16 ,25 ,45,64,100,67 , 6};
               // int N = arr.Length;
                countSquares(arr);
            
            }
        

    }
}

