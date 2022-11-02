using System;
using System.Threading;
using System.Text;

namespace MyProject1
{
    public delegate int Mydelegate(int a, int b);
    class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Mydelegate myDelegate = new Mydelegate(calc.Add);
            int sum = myDelegate.Invoke(45, 23);
            Console.WriteLine(sum);

        }
    }

    
}
