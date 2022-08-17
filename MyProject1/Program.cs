using System;

namespace MyProject1
{
    class DivisibleBy5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
                
            
            if (num%5 == 0)
            {
                Console.WriteLine("num is Divisible by 5");
            }
            else
            {
                Console.WriteLine("num is not Divisible By 5 ");
            }
        }
    }
}