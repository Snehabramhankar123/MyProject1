using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1 to 7");
            int num = int.Parse(Console.ReadLine());


            if (num == 1)
            {


                Console.WriteLine("Monday");

            }
            else if (num == 2)
            {
                Console.WriteLine("Tuesday");

            }
            else if (num == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }



        }
    }

        
    
}
