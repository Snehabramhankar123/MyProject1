using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SPYNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, p = 1;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                p = p * r;
                num = num / 10;
                if (sum == p)
                {
                    Console.WriteLine("Number is Spy Number");
                }
                else
                {
                    Console.WriteLine("Number is Not Spy Number");
                }
            }
            
        }
    }
    class Series
    {
        static void Main(string[] args)
        {
            for(int i =1; i<= 20; i++)
            {
                Console.WriteLine((i*i)+(i*i*i));
            }
        }
    }
}
