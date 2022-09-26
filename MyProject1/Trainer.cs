using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Trainer
    {
        string name;
        string qualification;
        int experience;
        public Trainer(string name, string qualification, int experience)
        {
            this.name = name;
             this.qualification = qualification;
            this.experience = experience;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Qualification
        {
            set { qualification = value; }
            get { return qualification; }
        }
        public int Experience
        {
            set { experience = value; }
            get { return experience; }
        }
    }
    class Batch
    {
        string batchname;
        string technology;
        public Batch(string batchname, string technology)
        {
            this.batchname = batchname;
            this.technology = technology;
        }
        public string Batchname
        {
            set { batchname = value; }
            get { return batchname; }
        }
        public string Technology
        {
            set { technology = value; }
            get { return technology; }
        }
    }
    class Student
    {
        string studname;
        int passoutyear;

          public Student(string studname ,int passoutyear)
         {
         this.studname = studname;
         this.passoutyear = passoutyear;
          }
        public string Studname
        {
            set { studname = value; }
            get { return studname; }
        }
        public int Passoutyear
        {
            set { passoutyear = value; }
            get { return passoutyear; }
        }

        static void Main(string[] args)
        {
            Trainer t1 = new Trainer("Deepa mam","B.E.",10 );
            t1.Name = "Deepa mam";
            t1.Qualification = "B.E.";
            t1.Experience = 10;
            Batch b1 = new Batch("Wipro", "c#");
            //b1.T= t1;
            Student s1 = new Student("Sneha", 2020 );
            s1.Studname = "Sneha";
            s1.Passoutyear = 2020;
         //   s1. B = b1;


        }
    }




    
}
