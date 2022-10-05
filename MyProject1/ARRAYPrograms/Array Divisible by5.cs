using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Array_Divisible_by5
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter Size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elemets");
            int ele = int.Parse(Console.ReadLine());
            int n;
                    
                int[] m = new int[5];

            
            for (int i=0; i<m.Length; i++)
            {
                //m[i] = int.Parse(Console.ReadLine());
                if (m[i] % 5 ==0)
                
                    Console.Write(m[i]);
                
               
                
            
                

            }
        }
    }
    class  B2
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 44, 55 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c =new int  [ a.Length + b.Length ];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                count++;
            }
            for (int i=0; i< b.Length; i++)
            {
                c[a.Length + i] = b[i];

            }
            for(int i= 0; i< c.Length; i++)
            {
                Console.WriteLine(  c[i]  );
            }

        }
    }
    class B3
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 44, 55 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];



            for (int i = 0; i < 10; i++)
            {
                if (i < a.Length)
                    c[i] = a[i];
                else
                    c[i] = b[i - a.Length];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

            
        }
    }
    class D4
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 7,9 };
            int[] b = { 2, 4, 6, 8, 10};
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i =0; i<c.Length;)
            { 
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                    k++;
            }
            
            for(int i=0; i< c.Length; i++)
            {
                Console.WriteLine(c[i]+" ");
            }


        }
    }
}
