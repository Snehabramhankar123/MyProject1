using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    abstract class Teacher
    {
        string tid;
        string tname;
        long mobileNo;
        public Teacher()
        {

        }
        public string Tid
        {
            set { tid = value; }
            get { return tid; }
        }
        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }
        public long MobileNo
        {
            set { MobileNo = value; }
            get { return MobileNo; }
        }
        public Teacher(string tid, string tname, long mobileNo)
        {
            this.tid = tid;
            this.tname = tname;
            this.mobileNo = mobileNo;
        }
        abstract public void Salary();

    }
    class Hourlybased : Teacher
    {
        int rate_per_hr;
        int hrs;
       public Hourlybased ()
       { 

        }
        public Hourlybased(string tid, string tname,long mobileNo ,int rate_per_hr, int hrs):base (tid ,tname, mobileNo)
        {
            this.rate_per_hr = rate_per_hr;
           this.hrs = hrs;
        }
        public int Rate_per_hr
        {
            set { rate_per_hr = value; }
            get { return rate_per_hr; }
        }
        public int Hrs
        {
            set { hrs = value; }
            get { return hrs; }
        }
        public override void Salary ()
        {
            Console.WriteLine("Hourly teacher Salary" +hrs*rate_per_hr);
        }

    }
    class SalaryBased : Teacher
    {
        int salary;
        public SalaryBased()
        {

        }

        public SalaryBased(string tid, string tname, long mobileNo, int salary) : base(tid,tname,mobileNo)
        
        {
          this.salary = salary;
            
        }
        
       // public int Salary
       // {
        //   set { salary = value; }
        //    get { return salary; }
       // }
        public override void Salary()
        {
            throw new NotFiniteNumberException();
        }
    }
        class TeacherTest
        {
            static void Main(string[] args)
            {
                Teacher h1 = new Hourlybased();
               Teacher s = new SalaryBased();
                // Teacher h1 = new Teacher();
                // h1.salary(50000);  */

            }
        }
    
    
}


    

    
        
              
        


    
      
