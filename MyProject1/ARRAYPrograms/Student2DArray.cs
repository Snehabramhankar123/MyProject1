using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Student
    {
        string name;
        int roll_no;
        int percent;
        public Student()
        {

        }
        public Student(string name, int roll_no, int percent)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.percent = percent;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Roll_no
        {
            set { roll_no = value; }
            get { return roll_no; }
        }
        public int Percent
        {
            set { percent = value; }
            get { return percent; }
        }
        public void showdata()
        {
            Console.WriteLine("Student name " + name);
            Console.WriteLine("Roll no" + roll_no);
            Console.WriteLine("Percent" + percent);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Student[] sarr = new Student[5];
            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine("Enter name , roll_no, percent");
                string nm = Console.ReadLine();
                int roll_no = int.Parse(Console.ReadLine());
                int percent = int.Parse(Console.ReadLine());
                sarr[i] = new Student(nm, roll_no, percent);
            }
            for(int i=0; i< sarr.Length; i++)
            {
                Console.WriteLine(sarr[i]);
            }
        }
    }
}
