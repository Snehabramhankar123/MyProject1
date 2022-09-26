using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Power2
    {
        public int Power(int b, int idx)
        {


            int result = 1;
            for (int i = 1; i <= idx; i++)
            {
                result = result * b;

            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Index");
            int idx = int.Parse(Console.ReadLine());

            Power2 p = new Power2();
            p.Power(b, idx);
            Console.WriteLine(p.Power(b, idx));

        }
    }
}


    

