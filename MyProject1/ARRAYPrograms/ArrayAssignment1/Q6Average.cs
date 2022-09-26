using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q6Average
    {
        public static int average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return  sum / array.Length;
        }
        public static double average(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum / array.Length;
        }
        
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 67 };
            double[] b = { 2, 3, 4, 5, 7, 8, 9, 2, 1, 9,  };
            int  avg1 = average(a);
            Console.WriteLine(avg1);
            double avg2 = average(b);
            Console.WriteLine(avg2);



            
        }
    }
}
