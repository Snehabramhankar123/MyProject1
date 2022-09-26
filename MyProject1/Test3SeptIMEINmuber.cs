using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Test3SeptIMEINmuber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            //int r = num % 10; 
           int  sum = 0; int r = 0;
            while(num>0)
            {
                 r = num % 10;
                //  r % 2 = 0;
                while(num>9)
                {

                }
                sum = sum + r;
                


            }
            if (sum % 10 == 0)
            {
                Console.WriteLine("IMEI Number is Valid");
            }
            else
            {
                Console.WriteLine("IMEI Number is Not Valid");
            }
            
        }
    }
}
