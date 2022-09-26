using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    
    
        class Overload1
        {
            public int num_calc(int num, char ch)
            {
                int result = 1;
                if (ch == 's')
                {
                    result = num * num;
                }
                else
                {
                    result = num * num * num;
                }
                return result;


            }

            public int num_calc(int a, int b, char ch)
            {
                int prod = 1;
                if (ch == 'p')
                {
                    prod = a * b;
                }
                else
                {
                    prod = a + b;
                }
                return prod;
            }



            static void Main(string[] args)
            {
                Overload1 p = new Overload1();
                int ans = p.num_calc(5, 's');
                Console.WriteLine(ans);
                int ans1 = p.num_calc(5, 5, 'p');
                Console.WriteLine(ans1);
            }
        }
    
}

