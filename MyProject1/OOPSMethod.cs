using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    public class Calculator1
    {
        int num1 = 10;
        int num2 = 20;
        int result;
        void Add()
        { result = num1 + num2;
            DisplayResult();
        }
        void Subtract()
        {
            result = num1 - num2;
            DisplayResult();
        }
        void Multiplication()
        {
            result = num1 * num2;
            DisplayResult();
        }
        void Division()
        {
            result = num1 / num2;
            DisplayResult();
        }

        void DisplayResult()
        {
            Console.WriteLine("Result is : " +result);
            Console.ReadLine();
        }
         static void Main (string[]args)
         {
            Calculator1 obj = new Calculator1();
            obj.Add();
            obj.Subtract();
            obj.Multiplication();
            obj.Division();
            Calculator1 c1 = new Calculator1();
            c1.num1 = 2;
            c1.num2 = 5;
            c1.Add();
            c1.Subtract();
            c1.Multiplication();
            c1.Division();

            
         }




    }
}
