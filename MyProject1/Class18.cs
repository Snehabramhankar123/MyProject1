using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Rect
    {
        int length;
        int breadth;
        public void Input (int l, int b)
        { 
           length =l;
            breadth= b;
            }
    public void Calculate(int l, int b)
    {
        length = l;
        breadth = b;
        int a = length * breadth;
        int P = 2 * length + 2 * breadth;
    }
        public void Display()
        {
            Console.WriteLine("Area is " +length*breadth);
            Console.WriteLine("Perimeter is "+(2*length+2*breadth));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");

            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int s = int.Parse(Console.ReadLine());
            Rect r = new Rect();
            r.Calculate(w, s);
            r.Display();




        }


    



    

    }
}
