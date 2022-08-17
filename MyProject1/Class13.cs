using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PosNeg
	
	
{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            string str = (Console.ReadLine());
            switch (num >= 0)
            {
                case true:
                    Console.WriteLine(" Number is Positive");
                    break;
                case false:
                    Console.WriteLine(" Number is Negative");
                    break;
            }
        }

       
        


                
             

            
        
    }
}
