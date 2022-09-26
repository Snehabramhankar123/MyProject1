using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Frequency1
    {
        static bool isAlreadyPresent(int[] a, int current)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 1, 2, 8, 2, 1, 3 };
            for (int i = 0; i < current; i++)
            {
                if (a[i] == a[current])
                    return true;

            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 1, 2, 8, 2, 1, 3 };
            for (int i = 0; i < arr.Length; i++)

                Console.Write(arr[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (isAlreadyPresent(arr, i) == false)
                {
                    int c = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                        }

                    }
                    Console.WriteLine($"Frequency of {arr[i]}={c}");



                }

            }
        }
    }
}

