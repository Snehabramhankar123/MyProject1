using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{    //rules 1: method call itself.
  //  rule 2 : method must have exit control.
    class Recursion
    {
        int num = 1;
        void Counting()
        {
            if (num == 11)
            {
                return;
            }

            Console.WriteLine(num);
            num++;
            Counting();
        }
        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            r.Counting();

        }
        class FactorialRecursion
        {
            int num = 5;
            int result = 1;
            int  Factorial()
            {
                if (num==0)
                {
                    return 1;
                }
                result = result * num;
                num--;
                Factorial();
                return result;
            }
            static void Main(string[] args)
            {
                FactorialRecursion f = new FactorialRecursion();
                int Factorial = f.Factorial();
                Console.WriteLine("Factorial is : " +Factorial);
                Console.ReadLine();

            }
        }

        


    }
}
