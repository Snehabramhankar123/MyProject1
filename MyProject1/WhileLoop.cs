using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the number");
            int num = int.Parse(Console.ReadLine());
            int end = num % 10;
            int start  =  0;
            while (num>0)
            {
                start = num % 10;
                num = num / 10;

            }
            Console.WriteLine(end + start);
        }
    }
}
