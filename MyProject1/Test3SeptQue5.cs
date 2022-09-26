using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Employee1
    {
        int id;
        string name;
       Dept d;
        public Employee1()
        {

        }
        public Employee1(int id, string name,Dept d )
        {
            this.id = id;
            this.name = name;
           this.d = d;
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Dept D
        {
           set {d = value; }
          get {  return  d; }
        }
    }
    class Dept
    {
        int deptid;
        string dname;
        public Dept()
        {
                
        }
        public Dept(int deptid ,string dname )
        {
            this.deptid = deptid;
            this.dname = dname;
        }
        public int Deptid
        {
            set { deptid = value; }
            get { return deptid; }
        }
        public string Dname
        {
            set { dname = value; }
            get { return dname; }
        }
        static void Main(string[] args)
        {
           Employee1 e1 = new Employee1(12345, "Sneha",new Dept(101,"IT"));
            Employee1 e = new Employee1();
            e.ID = (12345);
            e.Name = "Sneha";
            Dept d = new Dept();
            d.Deptid = 1234;
            d.Dname = "IT Dept ";
             e.D = d;
            Console.WriteLine(e1);
        }
        

        
    }

        
    
}
