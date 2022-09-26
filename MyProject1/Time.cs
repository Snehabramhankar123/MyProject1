using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Time
    {
        
        
            int hour;
            int min;
            int sec;

            public void set_time(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }

            public void show()
            {
                Console.WriteLine("Time is " + hour + min + sec);
            }

            static void Main(String[] args)
            {
                Console.WriteLine("Enter hours");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter min");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter sec");
                int c = int.Parse(Console.ReadLine());

                Time t = new Time();
                t.set_time(a, b, c);
                t.show();
            }



        
    }
}


