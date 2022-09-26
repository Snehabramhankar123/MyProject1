using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ArrayDiagonal
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(arr[i, j]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
    class DigonalOpposite
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------------------------------");
            for(int i=0; i< arr.GetLength(0); i++)
            {
                for(int j=0; j< arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j == arr.GetLength(1) - 1)
                        Console.Write(arr[i, j] );
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                
            }
            


             
        }
    }
}

