using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Student1
    {
        int sid;
        string sname;
        string qualification;
        int experience;
     
        


        public Student1(int sid, string sname, string qualification, int experience):this(sid,sname)
        {
         
            
            this.qualification = qualification;
            
        }

        public Student1(int sid)
        {
            this.sid = sid;
        }

        public Student1(int sid, string sname) : this(sid)
        {
            this.sname = sname;
        }

        public Student1(string qualification, int experience)
        {
            this.qualification = qualification;
            this.experience = experience;
        }
        static void Main(string[] args)
        {
            Student1 s = new Student1(1, "Om", "BE", 2);
        }
    }
}
