using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class ArrayPrime
    {
        public bool IsPrime(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

            //  bool b = IsPrime(n);
        }
        static void Main(string[] args)
        {
            ArrayPrime a1 = new ArrayPrime();
            bool b = a1.IsPrime(5);

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int c = 0; //int n;
            for (int i = 0; i < a.Length; i++)
            {
                // if(bool b == true)


                // bool b = a1.IsPrime(n);
                Console.Write(a[i]);
            }
        }
    }
    class PrimeArray
    
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the Size of Array");
            // int size = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Enter the Elements of an Array");
            //  int n = int.Parse(Console.ReadLine());
            // int[] arr = new int[100];
            int[] arr = { 1, 2, 3, 5, 67, 8, 9 };
            
            for(int i= 0; i< arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is :");
            for(int i=0; i< arr.Length; i++)
            {
                Console.WriteLine("\t" ,arr[i]);
            }
            Console.WriteLine("All the Prime Numbers in Array are");
            for(int i=0; i<arr.Length; i++)
            {
                int counter = 0;
                for(int j=2; j<arr[i];j++)
                {
                    if(arr[i]%j==0)
                    {
                        counter = 1;
                        break;
                    }
                }
                if(counter ==0)
                {
                    Console.WriteLine("\t" ,arr[i]);
                }
            }
        }
    }
                
            

        


            
            
        
    
}
