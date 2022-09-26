using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ColumnWise2D
    {
        static void Main(string[] args)
        {
            // int[] a = new int[3];
            // int [] a = { 1, 2, 3, 45 };
            // int[,] b = new int[3, 4];
            int[,] b = { { 2, 3, 4, 5 }, { 6, 7, 8, 9 } };


            for (int r = 0; r < b.GetLength(0); r++)
            {
                for (int c = 0; c < b.GetLength(1); c++)
                {
                    Console.Write(b[r, c] + " ");
                }
                Console.WriteLine();
            }
            for (int c = 0; c < b.GetLength(1); c++)
            {
                int max = b[0, c];

                for (int r = 0; r < b.GetLength(0); r++)
                {
                    if (max < b[r, c])
                    {
                        max = b[r, c];
                    }

                }
                Console.WriteLine("max=" + max);
            }

        }
    }
    class RowWiseMax
    {
        static void Main(string[] args)
        {
            int[,] b = { { 2, 3, 4, 5 }, { 6, 7, 8, 9 } };


            for (int r = 0; r < b.GetLength(0); r++)
            {
                for (int c = 0; c < b.GetLength(1); c++)
                {
                    Console.Write(b[r, c] + " ");
                }
                Console.WriteLine();
            }
            for (int r = 0; r < b.GetLength(1); r++)
            {
                int max = b[r, 0];

                for (int c = 0; c< b.GetLength(0); c++)
                {
                    if (max < b[r, c])
                    {
                        max = b[r, c];
                    }
                }

                Console.WriteLine("Max=" + max);
            }
        }
    }
    class RowWiseSum
    {

        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            for (int r = 0; r < arr.GetLength(0); r++)
            {
             Console.WriteLine("Enter " + arr.GetLength(1) + "element for row" + r);
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    arr[r, c] = int.Parse(Console.ReadLine());

                }
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                }

            }
            Console.WriteLine("Row wise Sum is : " + sum);
        }
    }
    class ColumnWiseSum
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            for (int c = 0; c < arr.GetLength(0); c++)
            {
                Console.WriteLine("Enter " + arr.GetLength(1) + "element for column" + c);

                for (int r = 0; r < arr.GetLength(1); r++)
                {
                    arr[r, c] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                }

            }
            Console.WriteLine("Column wise Sum is : " + sum);
        }
    }
            
        

    
}