using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ArraySum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 5 Elements");
            int[] a = new int[5];
            int num, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num - 1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            

            for(int i=0; i< num-1;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum );

        }
    }
}
