using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class LongestSubArray
    {
        public  static int Longestsubarray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int zero = 0, one = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else if (arr[j] == 1)
                        one++;
                    if (zero == one)
                    {
                        //Console.WriteLine((arr,j));
                        if (max < j - i + 1)
                            max = j - i + 1;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0 };
            Longestsubarray(arr);
            Console.WriteLine(Longestsubarray(arr));
        }
                    
                

            
        
    }
}
