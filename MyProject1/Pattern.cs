﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int r=5;r>=1;r--)
            {
                for(int c=r;c>=1;c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
