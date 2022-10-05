using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class ArithmaticProgression
    {
        public static int Nth_Term(int a, int d, int N)
        {
            return (a + (N - 1) * d);
        }
        static void Main(string[] args)
        {
            int a = 2;
            int d = 1;
            Console.WriteLine("Enter the Nth Term");
            int N = int.Parse(Console.ReadLine());
            // Nth_Term(2, 1, N);
            Nth_Term(2, 1, N);
            Console.WriteLine("The" + N + "th term of the series is: " + Nth_Term(2, 1, N));
            // Nth_Term(2, 1, N);
        }
    }
        class AP
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Nth term");
                int N = int.Parse(Console.ReadLine());
                int Nth_Term;
                int a = 2; int d = 1;
                Nth_Term = a + (N - 1) * d;
                Console.WriteLine("The"+N+"th term of the series is:" +Nth_Term);
            }
        }

        

        
 
        
    
}
