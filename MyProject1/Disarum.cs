using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Disarum
    {
        public bool checkdisarum(int n)
        {    if (n == 0)

                return true;
            else
                return false;
           
            
               
            
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            Disarum d1 = new Disarum();
            
            int copy = num;
            int r = 0;
            int c = 0;
            int sum = 0;
           // d1.Power(r, c);
            while (num!=0)
            {
                c++;
                num = num / 10;
            }
            num = copy;
            while (num>0)
            {
                r = num % 10;
        //        sum = sum + d1.power(r, c);
                c--;
                num = num / 10;

            }

        }
    }
}
