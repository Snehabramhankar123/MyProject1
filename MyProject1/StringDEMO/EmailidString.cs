using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class EmailidString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the EmailID");
            string s = Console.ReadLine();
            //bool s1 = s.Contains();
            int idx = s.IndexOf('@');
            Console.WriteLine(idx);
        }
      
    }
}
