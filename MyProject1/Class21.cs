using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Class21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Binary Number");
            int num = int.Parse(Console.ReadLine());
            int r, c = 0, dec = 0,sum = 0;
            while(num>0)
            {
                r = num % 10;
                for(int i =1;i==1;i++)
                {
                    dec = r * (int)Math.Pow(2, c);

                }
                c++;
                sum = sum + dec;
                num = num / 10;
            }
            Console.WriteLine( sum );
        }
    }
    class ASP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Scott");
            
        }
    } 
    
}
