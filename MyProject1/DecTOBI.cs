using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class BinaryToDecimal1
    {
          static int Convert_Binary(int num)
          {
            int r, d;
            int result = 0;
            int i = 0;

            while (num > 0)
            {
                d = num % 10;
                r = d * i;
                result = r + result;
                num = num / 10;
                i = i * 2;

            }
            return num;
          }
        static void Main(string[] args)
        {
            BinaryToDecimal1 B = new BinaryToDecimal1();
            int num = Convert.ToInt32(Console.ReadLine());
            int result = Convert_Binary(num);

            Console.WriteLine(result);
        }
    }

}
