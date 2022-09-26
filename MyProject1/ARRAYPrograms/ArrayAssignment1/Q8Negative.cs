using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q8Negative
    {
  
        
            static void Main(string[] args)
            {
                int[] a = new int[8];
                Console.WriteLine("Enter Elements");

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());


                }

                for (int i = 0; i < a.Length; i++)
                {
                    int nega = 0;

                    if (a[i] < nega)
                    {
                        nega++;
                        Console.WriteLine("Negative no is " + a[i]);
                    }
                }

                Console.WriteLine(" ");


            }
        
    }
}
