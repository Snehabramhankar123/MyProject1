﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1 { 
////                                                                  87654321
////                                                                  7654321
////                                                                  654321
////                                                                  4321
////                                                                  321
////                                                                  21
////                                                                  1
    class PatternNumber
    {
        static void Main(string[] args)
        {
             for(int r= 8;r>=1;r--)
            {
                for( int c= r;c>=1;c--)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }
}
