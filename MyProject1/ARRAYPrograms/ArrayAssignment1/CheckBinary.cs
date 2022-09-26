using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class CheckBinary1
    {
        public bool CheckBinary(int n1)
        {
            int c = 0;
            while (n1 != 0)
            {
                int r = n1 % 10;
                c++;
                if (c % 2 == 1)
                {
                    if (r > 1)
                        return false;
                }
                n1 = n1 / 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            CheckBinary1 b = new CheckBinary1();
            bool result = b.CheckBinary(num);
            if(result)
            {
                Console.WriteLine("Binary Number");
            }
            else
            {
                Console.WriteLine("Invalid Binary Number");
            }
        }
    }
}
