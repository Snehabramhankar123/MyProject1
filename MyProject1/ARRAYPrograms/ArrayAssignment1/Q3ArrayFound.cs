using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Q3ArrayFound
    {
       static void Main(string[] args)
       {
            int[] a = { 1, 2, 3, 4, 5,6,7 };
            Console.WriteLine("Enter the Element to Search");
                int search = int.Parse(Console.ReadLine());
            int pos = -1;
            for(int i=0; i < a.Length; i++)
            {
                if (a[i] == search)
                {
                    Console.WriteLine("Element found at Positon " +i);
                    pos = 1;
                }
            }

            
          
             
       } 
    } 
}
