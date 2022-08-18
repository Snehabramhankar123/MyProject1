using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CubeOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine(cube);

        }
    }
}