using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Negative
    {
        static void Main(string[] args)
        {
           /* int[] a = new int[10];
            Console.WriteLine("Enter the Size");
             int size = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter" + size + "Elements");
             //int n = int.Parse(Console.ReadLine()); */ 
            int[] a = { 11, -3, -5, -6, 2, 3, 56, 12, -7, 2 };
            for (int i = 0; i < a.Length; i++)
            
              //  a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(a[i] + " ");
            
            Console.WriteLine();
            // int neg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
                if (a[i] < 0)

                   

                Console.WriteLine(a[i] + " ");
            }
                
            
          //  Console.WriteLine("");


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
                    }
                        Console.WriteLine("Negative no is " + a[i]);
                    
                }

                Console.WriteLine(" ");


            }
        }
           

                
            

                


                    
  


            


        
    }
}
