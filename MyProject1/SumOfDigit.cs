using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SumOfDigit
    { 
        public int DigitSum(int num)
        {
            int sum = 0;
            while(num>0)
            {
                
                
                   
                     

                    int r = num % 10;
                    sum = sum + r;
                    num = num / 10;
                
            }
            return sum;  
        }


        static void Main(string[] args)
        {
            SumOfDigit s = new SumOfDigit();
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int result = s.DigitSum(num);
            Console.WriteLine("SumOfDigits=" + result);
        }
    }
    class SumofEvenNumber
    {
        public int SumofEven(int n)
        {
            int sum = 0;
            int r;
            while(n>0)
            {
                r = n % 10;
                if (n % 2 == 0)
                 sum = sum + r;
                n = n / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            SumofEvenNumber e = new SumofEvenNumber();
            int result = e.SumofEven(n);
            Console.WriteLine("Sum of Even Number is : "  +result);
            Console.WriteLine("Sum of Even Number is : " + e.SumofEven(n));
        }
    }
    class SumofOddNumber
    {
        public int SumofOdd(int n)
        {
            int sum = 0;
            int r;
            while (n> 0)
            {
                r = n % 10;
                if (n % 2 !=0)
                    sum = sum + r;
                n = n / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            SumofOddNumber e = new SumofOddNumber();
            int result = e.SumofOdd(n);
            Console.WriteLine("Sum of Odd Number is : " + result);
            Console.WriteLine("Sum of Odd Number is : " + e.SumofOdd(n));
        }
    }
}

    

