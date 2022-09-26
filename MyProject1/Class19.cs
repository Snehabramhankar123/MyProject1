using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Combine1n2
    {
        public void number (int num ,int d)
        {
            int count = 0;
            while (num != 0)
            {
                int r = num % 10;
                if (r == d)
                {
                    count++;
                }
                num = num / 10;
            }
            Console.WriteLine("Frequency is " + count);

        }
        public void number(int n1)
        {
            int sum = 0;
            while (n1 != 0)
            {
                int r = n1 % 10;
                if (r % 2 == 0)
                {
                    sum = sum + r;
                }
                n1 = n1 / 10;
                Console.WriteLine("Sum of Even Number is " + sum);
            }
            
        }
        static void Main(string[] args)
        {
            Combine1n2 c = new Combine1n2();
            int num = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            c.number(num, d);
            int num1 = int.Parse(Console.ReadLine());
            c.number(num1);

        }
    } 

}
