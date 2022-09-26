using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{  //Herachial Inheritance
    class Bank

    {
        string bankname;
        string branch;
        string addresscode;
        string ifsc;

        public void accept()
        {
            Console.WriteLine("in accept");
        }
    }
    class  HDFC:Bank
    {
        float roi;
        static void Main(string[] args)
        {
            HDFC h = new HDFC();
            h.accept();
        }
    }
}
