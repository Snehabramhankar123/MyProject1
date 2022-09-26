using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Employee
    {
        string id;
        string name;
        int salary;

        public string ID
        {
            set { id= value; }
            get { return id; }
        }
        
         public string Name
        { 
            set { name = value; }
            get { return name; }
        }
        public int Salary
        { 
            set { salary = value; }
            get { return salary; }
        }
        static void Main(string[] args)
        {
            Employee s1 = new Employee();
            s1.ID ="Adhar Card";
            s1.Name = " Sneha";
            s1.Salary = 50000;
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.salary);
        }


    }
}
