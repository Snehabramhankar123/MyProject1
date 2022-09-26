using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    class Flat
    { 
         int flatno;
        string wingName;
        int member;
        public Flat ()
        {

        }
        public Flat(int flatno, string wingName, int member)
        {
            this.flatno = flatno;
            this.wingName = wingName;
            this.member = member;
        }
          public int Flatno
          {
            set { flatno = value; }
            get { return flatno; }
          }
        public string WingName
        {
            set { wingName = value; }
            get { return wingName; }
        } 
        public int Member
        {
            set { member = value; }
            get { return member; }
        }
    }
        class Member
        {
            int memberid;
            string membername;
            string profession;
            int age;
            public Member()
            {

            }
            public Member(int memberid, string membername, string profession, int age)
            {
                this.memberid = memberid;
                this.membername = membername;
                this.profession = profession;
                this.age = age;
            }
            public int Memberid
            {
                set { memberid = value; }
                get { return memberid; }
            }
            public string Membername
            {
                set { membername = value; }
                get { return membername; }
            }
            public string Profession
            {
                set { profession = value; }
                get { return profession; }
            }
            public int Age
            {
                set { age = value; }
                get { return age; }
            }
        }   
        class Flat1
        {
            static void Main(string[] args)
            {
                Flat f1 = new Flat();
                f1.Flatno = 105;
                f1.WingName = "ABCD";
                f1.Member = 5;
                Member m1 = new Member();
                m1.Memberid = 12345;
                m1.Membername = "Sneha";
                m1.Profession = "Student";
                m1.Age = 23;
                Console.WriteLine(f1.Flatno);
                Console.WriteLine(f1.WingName);
                Console.WriteLine(f1.Member );
                Console.WriteLine(m1.Memberid);
                Console.WriteLine(m1.Membername);
                Console.WriteLine(m1.Profession);
                Console.WriteLine(m1.Age);
            
            }
        }


        

            
        

          
        





    
}
