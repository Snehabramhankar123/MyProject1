using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class PrimeList
    {
        static void Main(string[] args)
        {
            // int[] a = new int[10];
            int f, n;
           int[] a = { 1, 2, 3, 4, 7, 9, 17, 56, 2, 55 };
           // int[] a = { 1, 3, 56, 7, 8,11 };
            //  Console.WriteLine("Enter the Elements");
            //for ( int i = 0; i < a.Length; i++)
            //   a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                

                n = a[i];
                f = 0;
                for (int j = 1; j < n/2 ; j++)
                {
                    if (n % j == 0)
                        f = 1;
                    {
                        break;
                    }
                }

                if (f == 0)
                    Console.WriteLine(" Prime Number is :" + n);



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

                    if (i % 2 == 0)
                        Console.WriteLine("Even Number is :  " + i);
            }
        }


    }
}
