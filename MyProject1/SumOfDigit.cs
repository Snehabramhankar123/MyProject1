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
}
