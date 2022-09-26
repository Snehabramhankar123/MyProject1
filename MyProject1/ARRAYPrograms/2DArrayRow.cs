using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ArrayRow2D
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Length={arr.Length}");
            int[,] arr2d = new int[3, 4];
            Console.WriteLine($"Length of 2D Array={arr2d.Length}");
            Console.WriteLine("rows"+arr2d.GetLength(0));
            Console.WriteLine("cols" +arr2d.GetLength(1));
            
        }
    }
}
