using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Array3row3col
    {
        static void Main(string[] args)
        {


            int[,] num1 = new int[3, 3];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    Console.Write("Element ({0},{1})", i, j);
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
                Console.WriteLine("Array in matrix");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}" + " ", num1[i, j]);
                }
                Console.WriteLine();
            }
                Console.ReadLine();
            
            
        } 
    }
}
