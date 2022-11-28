using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Prorigo
{
    class MagicNumber
    {
        public static bool isMagic(int n)
        {
            int sum = 0; int r;
            while (n > 0 || sum > 9)
            {
                if (n == 0)
                {
                    n = sum;
                    sum = 0;
                }
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }

            return (sum == 1);
        }
        public static void Main(String[] args)
        {
           // int n = 83557;
            //int n = 123456;
            if ((isMagic(83557)))
                Console.WriteLine("Magic Number");
            else
                Console.WriteLine("Not Magic Number");
        }
    }
    class Magic
    {
        static void Main(string[] args)
        {
            int x = 12345;
            //int x = 83557;

            if(x%9 == 1)
                Console.WriteLine("Magic Number");
            else
                Console.WriteLine(" Not Magic Number");


        }
    }
}
