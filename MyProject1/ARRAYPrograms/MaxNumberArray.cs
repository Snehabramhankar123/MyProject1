using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class MaxNumberArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
           
            int[] Ar = new int[6];
            for (int i = 0; i <= 5; i++)
            {

                Ar[i] = int.Parse(Console.ReadLine());
            }
            int min = Ar[0];
            int max = Ar[0];
            for (int i=0; i<= 5; i++)
            {
                if (min > Ar[i])
                {
                    min = Ar[i];
                }
                if ( max < Ar[i])
                {
                    max = Ar[i];
                }
            }
            Console.WriteLine("Min number is : " +min);
            Console.WriteLine("Max number is : " +max);

            
        }
    } 
    class A1
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 567, 3, 59, 354, 2, 9 };
            {
                int MaxNumber = ar[0];
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > MaxNumber)
                    {
                        MaxNumber = ar[i];
                    }
                }
                Console.WriteLine("The Max Number is : " +MaxNumber);
            }
        }
    }

}
