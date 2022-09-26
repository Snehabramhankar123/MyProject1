using System;
using System.Collections.Generic;                 //OUTPUT*:1
                                                  //     *  12  
using System.Text;                                     //   *  123
                                                         // *1234
namespace MyProject1                                      // *12345
{
    class PatternS
    {
        static void Main(string[] args)
        {
            for (int r= 1;r<=5;r++ )
            {
                for(int c =1;c<=r;c++)
                {
                    
                    {
                        Console.Write(c);
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
 
        

                       

