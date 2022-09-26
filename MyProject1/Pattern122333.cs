using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Pattern122333
    {
        static void Main(string[] args)
        {
           for(int r=1; r<=5;r++ )
            {
                for(int c=1;c<=r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }


    class Pattern12345
    {
        static void Main(string[] args)
        {


            int count = 0;

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}