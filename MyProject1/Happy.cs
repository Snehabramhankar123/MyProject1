using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Happy
    {
        static void Main(string[] args)
        { 
           int num = 206;
            bool isodd = false;
            for (int i = 2; i < num; i++) 
            {
                if (num % 2 != 0)
                    isodd = false;
            }
            if (isodd == true)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");


            }
        }
    }
}

