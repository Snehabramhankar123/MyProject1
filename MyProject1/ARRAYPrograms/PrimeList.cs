using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{ 
    class PrimeList
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int  f, n;
            Console.WriteLine("Enter the Elements");
            for ( int i = 0; i < 10; i++)
                a[i] = int.Parse(Console.ReadLine());
            for( int i=0; i<10; i++)
            {
                n = a[i];
                f = 0;
                for ( int j = 2; j < n  ; j++)
                {
                    if (n % j == 0)
                        f = 1;
                    {
                        break;
                    }
                }
                    if(f==0)
                        Console.WriteLine(" Prime Number is :" +n);
                
            }

        }
    }
    class EvenArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int f, n;
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < 10; i++)
                a[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                
                     if(i%2==0)
                    Console.WriteLine("Even Number is :  " +i);
    }   }
                


}
