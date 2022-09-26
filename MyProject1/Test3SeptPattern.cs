using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Test3SeptPattern
    { //int r;int c;
        static void Main(string[] args)
        {


            //  for (int r = 5; r >= 1; r--)
            // {
            //  for (int c = 1; c <= 2 * r - 1; c++)
            // {
            for (int i = 5; i >= 1; i--)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        // if (i % 2 == 1)
                        Console.Write(j);



                    }
                    Console.WriteLine();
                }
                else if (i % 2 == 0)
                {
                    char ch = 'A';
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    Console.WriteLine();
                }
            }

           
        }
    }

}
 
