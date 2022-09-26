using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q1Insert
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter the Array Elements ");
            for(int i =0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}" , a[i]);

            }
            Console.WriteLine("Entered Array Elements are : ");
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("{0}" , a[i]);
                Console.ReadLine();
            }
        }
    }
}
