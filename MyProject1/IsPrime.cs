using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class IsPrime
    {   public bool isPrime(int nm)
        {
            for (int i = 2; i <= nm/2 ; i++)
            {
                if (nm % i == 0)
                    return false;
                break;
            }
            return true;
        }
        static void Main(string[] args)
        {
            IsPrime pr = new IsPrime();
            int num = int.Parse(Console.ReadLine());
            bool result = pr.isPrime(num);
            Console.WriteLine(result);
            for (int j = 1; j <= 500; j++)
            {     
                
                  
                
            }
        }
    }

}
