using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class AccountNo
    {
        long Accountno;
        string Customername;

           
        public long accountno
    {
            set { accountno = value; }
            get { return accountno; }
        }
          public string customername
        {
            set { Customername = value; }
            get { return customername; }
        }
        static void Main(string[] args)
        {
            AccountNo  s1= new AccountNo();
            s1. Accountno = 123456789;
            s1.Customername = " Sneha";
            Console.WriteLine(s1.Accountno);
            Console.WriteLine(s1.Customername);

        }
              
    }
}
