using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class ArrayFibbo
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 1;
            int c = a + b;
            for (int i = 0; i <= 10; i++)
            {

                a = b;

                b = c;
                c = a + b;

                Console.WriteLine(a);

                int[] arr = new int[5];
                Console.WriteLine(arr[i]);

            }

        }
    }
}

