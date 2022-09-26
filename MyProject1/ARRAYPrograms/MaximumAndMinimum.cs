using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class MaximumAndMinimum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");

            int[] a = new int[6];
            for (int i = 0; i <= 5; i++)
            {

                a[i] = int.Parse(Console.ReadLine());
            }
            int min = a[0];
            int max = a[0];
            for (int i = 0; i <= 5; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                else

                {
                    max = a[i];
                }
            }
            Console.WriteLine("Min number is : " + min);
            Console.WriteLine("Max number is : " + max);
        }
    }


        
    
}

