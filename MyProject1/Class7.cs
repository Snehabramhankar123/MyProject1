using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter your choice ");
            int choice = int.Parse(Console.ReadLine());
                  
            switch (choice)
            {
                case 1:  Console.WriteLine("Addition=" + (num1 + num2));
                    break;
                case 2: Console.WriteLine(" Subtraction=" + (num1 - num2));
                    break;
                case 3: Console.WriteLine(" Multiplication=" + (num1 * num2));
                    break;
                default:Console.WriteLine(" Division=" + (num1 / num2));
                    break;

            }
        }
    }





  
    

    
}
