using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Account
    {
        string accname;
        int accid;
        int bal;
        public string Accname
        {
            set { accname = value; }
            get { return accname; }
        }
        public int AccId
        {
            set { accid = value; }
            get { return accid; }
        }
       public Account (string accname , int accid )
        {
            this.accname = accname;
            this.accid = accid;
        }
        static void Main(string[] args)
        {

        
            Account a1 = new Account("Sneha", 12345);
        }

           


    }
}
