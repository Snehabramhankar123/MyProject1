using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class UniqueOnly1
    {
        public static int uniqueEle(int[] arr, int n)
        {
            int count = 1;
            for (int i = 0; i < n; i++)

                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                        break;

                    if (j == n)
                    {
                        Console.WriteLine("Unique Elements in Array is : ", count, arr[i]);
                        count++;
                    }
                }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter {arr.Length} Elements");
            int n = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 1, 3, 4, 5, 6, 7, 8 };
            uniqueEle(arr, n);
            Console.WriteLine("Unique Elements are"+arr,n);

            /* int arr[5];
           Console.WriteLine("Enter the Array Elements");
           for(int i=0; i< n; i++)
           {
             arr[i] = int.Parse(Console.ReadLine());
            */



        }
    }
               

            
            
       
    
}
            
