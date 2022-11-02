using System;
using System.Threading;
using System.Text;

namespace MyProject1
{
    public class Test
    {
        public void Run1()
        {
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine(currentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void Run2()
        {
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine(currentThread.Name);
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Thread t1 = new Thread(new ThreadStart(test.Run1));
            Thread t2 = new Thread(new ThreadStart(test.Run2));
            Thread t3 = new Thread(new ThreadStart(test.Run2));
            t1.Name = "Thread 1";
            t2.Name = "Thread 2 ";
            t3.Name = "Thread 3";
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();

        }
    }
   
}
