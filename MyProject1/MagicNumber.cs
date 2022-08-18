using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int magicnum = 45;
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if(num >magicnum )
                {
                    Console.WriteLine("Number is greater try again......");
                    continue;
                }
                else if (num< magicnum)
                {
                    Console.WriteLine("Number is less try again........");
                    continue;
                }

                else
                {
                    Console.WriteLine("Guess number is Correct........");
                    break;
                }
            }

        }
    }
}
