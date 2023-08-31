using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    
    class SecondMax
    {
        static void Main(string[] args)
        {
            //int[] arr = { 12, 3, 45, 67, 34, 21, 89, 5 };
          //  int[] arr = { 1, 23, 56, 78, 90, 234, 890 };
            int[] arr = { 56, 2, 45, 67, 11, 34, 8, 66, 22 };
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            int max = int.MinValue;
            int secondmax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)

                {
                    secondmax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondmax && arr[i] != max)
                { 
                    secondmax = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Second max " + secondmax);

        }
    }
  class SecondMax1
  {
    static void Main(string[] args)
    {
        int[] arr = { 12, 3, 45, 67, 34, 21, 89, 5 };
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
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
        Console.WriteLine("Second Max" + arr[arr.Length - 2]);




    }
  }
}


            
        
    

