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
                int a = 2;  int d = 1;
                Nth_Term = a + (N - 1) * d;
                Console.WriteLine("The"+N+"th term of the series is:" +Nth_Term);
            }
        }
    class Arithmaticprogression
    {
        static void Main(string[] args)
        {
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;
            //a2 = 2; a3 = 3; n = 4;
            for (int i = 4; i <= n; i++)
            {
                a3 = a3 + d;
            }
            Console.WriteLine(a3);
            Console.WriteLine("Nth term is :" + a3);
        }

    }
    class Ap1
    {
        public int NthTerm(int input1,int  input2,  int input3)
        {
            int d = input2 - input1;
            for (int i = 4; i <= input3; i++)
            {
                input2 = input2 + d;
            }
            return input2;
        }
        static void Main(string[] args)
        {
            Ap1 o = new Ap1();
            o. NthTerm(1,2,4);
            Console.WriteLine("Nth term is : " +o.NthTerm(1,2,4));
            Console.WriteLine(o.NthTerm(5,8,4));
        }
    }
}
   

        

        
 
        
    

