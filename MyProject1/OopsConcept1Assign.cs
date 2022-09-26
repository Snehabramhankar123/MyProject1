using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class AccountInfo
    {
        string accInfo;
        int dep;
        public string AccInfo
        {
            set { accInfo = value; }
            get { return accInfo; }
        }
         public int Dep
        {
            set { dep = value; }
            get { return dep; }
        }

        static void Main(string[] args)
        {
            AccountInfo s1 = new AccountInfo();
            s1.AccInfo = " Sneha ";
            s1.dep = 40000;
            Console.WriteLine(s1.AccInfo);
            Console.WriteLine(s1.dep);
                
        }
    }
}
