using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ArrayPrime
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 7, 89, 90 };
            for(int i=1; i< arr.Length; i++)
            {
                int n = arr[i];
                int f = 0;
                for(int j=0;j< n/2; j++)
                {
                    if (n % j == 0)
                        f = 1;
                    {
                        break;
                    }
                }
                if (f==0)
                    Console.WriteLine("The Prime Number is :" +arr[i]);
            }
        }
    }
}
