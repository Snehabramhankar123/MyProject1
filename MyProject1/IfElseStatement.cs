using System;
using System.Collections.Generic;
using System.Text;

    class IfElseStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Passing year");
            int yr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            int per = int.Parse(Console.ReadLine());
            if (yr == 2022)
            {
                if (per > 60)
                {
                    Console.WriteLine("Student is selected for Interview");
                }
                else
                {
                    Console.WriteLine("year is correct but per is less than 60");
                }
                
            }
            else
            {
                Console.WriteLine("student not selected");
            }
            
        }
    }

