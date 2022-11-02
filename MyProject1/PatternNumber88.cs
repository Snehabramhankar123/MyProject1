using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PatternNumber88
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
     class  A1
     {
         public virtual void m1()
        {
            Console.WriteLine("m11111");
        }

    }
    class C1 : A1
    {
        public  sealed override void m1()
        {
            Console.WriteLine("m111111");
        }
    }
    public class DemoEncap
    {
        private string studentName;
        private int studentAge;
        public string StudentName
        { set { studentName = value; }
            get { return studentName; }
        }
        public int StudentAge
        {
            set { studentAge = value; }
            get { return studentAge; }
        }
    }
    class A2
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();
            obj.StudentAge = 21;
            obj.StudentName = "Sneha";
            Console.WriteLine("Name:" +obj.StudentName);
            Console.WriteLine("Age: " + obj.StudentAge);
        }
    }
    class Overload
    {
        public void m1(int a)
        {

        }
        public void m1(float a)
        {

        }
        public void m1(string a)
        {

        }
        public void m1(int a, int b)
        {

        }
        public void m1(float a,int b)
        {

        }
        public void m1(int a, int b, float c)
        {

        }
    }
    //Method Overloading Rules
    //1. having differnt returntypes.
    //2.Have different access modifiers.
    // 3.  Throw different checked or unchecked exceptions.

}
