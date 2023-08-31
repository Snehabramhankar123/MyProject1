using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Fibbo
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 1;
            int c = a + b;
            for (int i = 0; i <= 10; i++)
            { 
                a = b;

                Console.WriteLine(a);
                b = c;
                c = a + b;
                int[] arr = new int[10];
                Console.WriteLine(arr[i]);

            }

        }
    }
    class Array1
    {
        static void Main(string[] args)
        {
           int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Hello World");
            s = Console.ReadLine();
            Console.WriteLine();
            Console.ReadLine();

        }
    }

}

