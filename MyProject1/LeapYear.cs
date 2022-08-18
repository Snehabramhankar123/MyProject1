using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{   //program to check year is leap or not //
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Year is Leap year");
            }
            else
            {
                Console.WriteLine(" Year is not Leap year");
            }

        }
    }
}
  