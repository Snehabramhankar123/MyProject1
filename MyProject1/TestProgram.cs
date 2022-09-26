using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Number
    {
        static int increasing(int n)
        {
            int d, x, flag = 1;
            while (n > 9)
            {
                d = n % 10;
                x = (n % 100) / 10;
                if (x > d)
                {
                    flag = 0;
                    break;
                }
                n = n / 10;
            }
            return flag;
        }
        static int decreasing(int n)
        {
            int d, x, flag = 1;
            while(n>9)
            {
                d = n % 10;
                x = (n % 100) / 10;
                if(x<d)
                {
                    flag = 0;
                    break;
                }
                n = n / 10;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Number n1 = new Number();
            
            Console.WriteLine("Enter number having 3 or more digits");
            int num = int.Parse(Console.ReadLine());
            
            if (num< 999)
                Console.WriteLine("Invalid Output");
            else if (increasing(num) == 1)
                Console.WriteLine("Increasing Number"); 
            else if (decreasing(num) == 1)
                Console.WriteLine("Decreasing Number");
            else
                Console.WriteLine("Bouncy Number");

        }
           
     
    }
}
