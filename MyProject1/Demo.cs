using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the city name");
            string city = Console.ReadLine();
            Console.WriteLine(city);
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + 2);
            Console.WriteLine("Enter temprature");
            float temp = float.Parse(Console.ReadLine());
            Console.WriteLine(temp);
            Console.WriteLine("Enter flag");
            bool flag = bool.Parse(Console.ReadLine());
            Console.WriteLine(flag);
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine( ch); 
        }
    }
}
