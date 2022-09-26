using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Average
    {
        public void SumAvgElements(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum =  sum + arr[i];//sum += arr[i]
            }
            average = sum / size;
            Console.WriteLine("Sum of Array is: " + sum);
            Console.WriteLine("Average of Array is: " + average);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the Size ");
            size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Elements of the Array: ");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int len = a.Length;
            Average a1 = new Average();
            a1.SumAvgElements(a, len);

        }
    }
}
