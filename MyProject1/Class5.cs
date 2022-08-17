using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TernaryPosNeg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            string ans = num > 0 ? " num is Positive" : " num is negative";
            Console.WriteLine(ans);
        }



    }





/*
     static void Main(string[] args)
    {

    


        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            string ans = num % 2 == 0 ? " num is Even" : " Num is Odd";
            Console.WriteLine(ans);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st  number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is Greater");

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(" num2 is Greater");

            }
            else
            {
                Console.WriteLine("num3 is Greater");
            }
        }
    }*/
}
    