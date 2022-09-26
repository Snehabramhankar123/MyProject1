using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q4CopyArray
    {
        static void Main(string[] args)
        {
        
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int i, n;
            Console.WriteLine("Copy the Elements ");
           
           
            n = int.Parse(Console.ReadLine());
                Console.WriteLine("Input {0} elements in the array ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
           
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", arr1[i]);
            }
            for(i=0; i<n; i++)
            {
                Console.WriteLine("{0}", arr2[i]);
                Console.ReadLine();
            }
            
                
            

        }
    }
}
