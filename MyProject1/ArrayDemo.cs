using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("Enter 5 elements");
            for ( int i=1;i<5; i++)
            {
                
                
                b[i] = int.Parse(Console.ReadLine());
                
            }
            for(int i= 0;i<10; i++)
            {
                Console.WriteLine("data=" + b[i]);
            }


        } 
    }
    class Array1
    {
        static void Main(string[] args)
        {
            int[] b = new int[10];
            Console.WriteLine("Enter 10 Elements");
            int even = 0;
            int odd = 0;
            for(int i=0; i<=9;i++)
            { 
                     if(b[i]%2 ==0)
                   {
                    Console.WriteLine("Even no =  " +b[i]);
                    even++;
                }
                     else 
                    odd++;
            }

        }
    }
    class Demo3
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i =0; i<10; i++)
            {
                
                if(a[i]%5==0)
                {
                    a[i] = a[i] + 5;
                    Console.WriteLine(a[i]);
                }
                else
                {
                    Console.WriteLine("Not");
                }
            }


        }
    }
    class Array3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Length= "+a.Length);
        }
    }
}
