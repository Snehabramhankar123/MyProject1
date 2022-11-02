using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CountEvenNumber
    {
        public  static void  Number(int n)
        {
            int r, count = 0;
            while(n!=0)
            {
                r = n % 10;
                if(r%2 ==0)
                {
                    count++;
                }
                n = n / 10;
            }
            Console.WriteLine("The Even Number Count is:" +count);
        }
        static void Main(string[] args)
        {
            Number(345554444);
        }
    }
    class Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int r, count = 0;
            while (n != 0)
            {
                r = n % 10;
                if (r % 2 == 0)
                {
                    count++;
                }
                n = n / 10;
            }
            Console.WriteLine("The Even Number Count is : " +count);

        }
    }
}
