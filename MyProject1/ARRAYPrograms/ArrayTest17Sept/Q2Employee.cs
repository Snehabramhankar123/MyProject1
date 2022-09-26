using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayTest17Sept
{
    class Employee
    {
        string name;
        int eid;
        int mgrid;
        public Employee()
        {

        }
        public Employee(string name , int eid , int mgrid )
        {
            this.name = name;
            this.eid = eid;
            this.mgrid = mgrid;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Mgrid
        {
            set { mgrid = value; }
            get { return mgrid; }
        }
        static void Main(string[] args)
        {
            Employee[] earr = new Employee[5];
            earr[0] = new Employee( "Pranav", 1 ,1);
            earr[1] = new Employee("Medha", 2, 1);
            earr[2] = new Employee("Deepa", 3, 2); 
            earr[3] = new Employee("Swati", 4, 2);
            earr[4] = new Employee("Kirti", 5, 3);

            foreach (Employee e in earr)
            {
                foreach(Employee m in earr)
                {
                    if(e.Mgrid== m.Eid)
                    {
                        Console.WriteLine("$EmployeeName:{e.Ename} ManagerName:{m.Ename}");
                    }
                }
            }











        }

    }

}



    
    
         

         
    

    

