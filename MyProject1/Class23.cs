


using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Class23
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            String strNo = number.ToString();
            int l = strNo.Length;
            int ctr = 0;
            char chr;
            for ( int i =1; i < l; i++)
            {
                chr = strNo[i];
                if (chr =='0')
                {
                    ctr++;
                    break;
                }
            }
            char f = strNo[0];
            if (ctr > 0 && (f == '0' || f != '0'))
                Console.Write("Duck");
            else
                Console.Write("Not Duck");
        }
    }
}    
