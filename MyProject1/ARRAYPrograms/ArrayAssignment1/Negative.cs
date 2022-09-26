using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Negative
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int neg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    neg++;
                    Console.WriteLine("Negative Number : " + a[i]);
                }
            }
            Console.WriteLine("");


            static void Main(string[] args)
            {
                int[] a = new int[8];
                Console.WriteLine("Enter elements");

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
}
