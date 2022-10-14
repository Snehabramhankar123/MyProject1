using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class GotoLABEL
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
        label:
            i++;
            j += i;
            if(i<10)
            {
                Console.Write(i + " ");
                goto label;
            }

        }
    }
    
}
