using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Calculator
   
    {
        int a, b, c;


    public void readdata(int e, int f)
    {
        a = e;
        b = f;

    }
    public int Add()
    {

        c = a + b;
        return c;
    }

    public void subtract(int a, int b)
    {
        c = b - a;
        Console.WriteLine(c);

    }

    public int multiply()
    {
        c = a * b;
        return c;

    }

    public float div()
    {
        c = a / b;
        return c;
    }

    static void Main(String[] args)
    {
        Console.WriteLine("Enter 1st no");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd no");
        int num2 = int.Parse(Console.ReadLine());

        Calculator c = new Calculator();
        int d = c.Add();
        float e = c.div();
        int f = c.multiply();

        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);






    }








}
}
