using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.PracticeofPattern
{
    class  Abcd
    {
        static void Main(string[] args)
        {
            for(int r=1;r<=5;r++)
            {
                for(int c=1;c<=r;c++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
           
            for (int r = 1; r <= 4; r++)
            {
                for (int c = r; c <= 4; c++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
           // for (int r = 1; r <= 5; r++)
           // {
              //  for (int c = 1; c <= r; c++)
                //{
                  //  Console.Write("*");

                //}
              //  Console.WriteLine();
           // }

        }
    }
}
