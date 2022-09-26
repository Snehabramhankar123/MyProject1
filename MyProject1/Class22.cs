using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Class22
    {
        static bool check_duck(string num)
        {
            int i = 0, n = num.Length;
            while (i < n && num[i] == '0')
                i++;
            while (i<n )
            {
                if (num[i] == '0')
                    return true;
                i++;
            }
            return false;
        }
        public static void Main ()
        {
           // Console.WriteLine("Enter the Number");
           // int  num1 = int .Parse(Console.ReadLine());
            string num1 = "0042";
           if (check_duck(num1))
            {
                Console.Write("   is a Duck Number ");
            }
            else
            {
                Console.Write("  is not a Duck Number");   
            }
            
        }
    }
}
