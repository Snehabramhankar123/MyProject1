﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TwinNumber
    {
        bool isPrime(int n)

        {
            int c = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    c++;
                    break;
                }
            }
            if (c == 0)
                return true;
            else
                return false;

        }

        static void Main(string[] args)
        {
            TwinNumber t1 = new TwinNumber();
            int a = 15;
            int b = 13;
            bool b1 = t1.isPrime(a);
            bool b2 = t1.isPrime(b);
            if (b1 == true && b2 == true)
            {
                if (a - b == 2 || b - a == 2)
                    Console.WriteLine();
            }
        }
    }
    
}


    

