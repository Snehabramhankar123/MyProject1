using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NumberIsMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  1st number");

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine( num1+"  is maximum");

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2+" is maximum");

            }
            else
            {
                Console.WriteLine(num3+ " is maximum");
            }



        }  
       
 
          

            
    }
}
