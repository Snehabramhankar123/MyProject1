
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ClassForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
           
            int i = num * num;
            for (i = 1; i <= 20; i++) 
            Console.WriteLine("i");
        }
    }
}
