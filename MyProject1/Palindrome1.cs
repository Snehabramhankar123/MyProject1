using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Palindrome1
    {
        public bool Check(int n)
        {
            int r, temp, sum = 0;
            temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

            
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());

            Palindrome1 n = new Palindrome1();

            bool b = n.Check(num);

            if (b == true)
            {
                Console.WriteLine("No is palindrome");
            }

            else
            {
                Console.WriteLine("No is not palindrome");
            }

        }

    }
}
    

