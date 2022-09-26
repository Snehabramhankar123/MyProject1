using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms.ArrayAssignment1
{
    class Student
    {
        string name;
        int rollno;
        int percent;
        string[] hobbies;
        public Student()
        {

        }
        public string[] Hobbies
        {
            set { hobbies = value; }
            get { return hobbies; }
        }
       // public int[] Rollno
       /// {
         ////   set { rollno = value; }
           // get { return rollno; }
       /// }
      //  Student sarr = new Student[5];
       //sarr[0] = new Student("om" ,1, 90);

        //for(int i=0; i<sarr.Length ; i++ )
         //   {
         //   Console.WriteLine(  "Enter id , name,percent");

          //  }
            

    }
}
