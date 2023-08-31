using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ReversrNumber1
    {
        public static int ReverseNumber(int n)
        {
            int reversenumber = 0;

            while (n != 0)
            {
                
                
                 int remainder= n % 10;
                reversenumber = reversenumber * 10 + remainder;
                n = n / 10;
            }
            return reversenumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int reversenumber = ReverseNumber(n);
            Console.WriteLine("The Reverse number is: "  +reversenumber );
        }
    }
    class Reverse1
    {
       
        public static int Reverse(int n)
        {
            int reverseNumber = 0;

            while (n != 0)
            {
                int remainder = n % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                n /= 10;
            }

            return reverseNumber;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reversedNumber = Reverse(number);
            Console.WriteLine("Reversed Number: " + reversedNumber);
        }
    }

}

    