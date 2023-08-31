  
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class ValidName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Name");
            string s = Console.ReadLine();
            bool isValid = true;
            string s2 = "";
            foreach (char ch in s)
            {
                // if((ch>='A'&& ch <='Z')|| ( ch>='a' && ch <= 'z'))
                if (char.IsLetter(ch) == false)
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
                Console.WriteLine("Valid Name");
            else
                Console.WriteLine("Not Valid");
        }
    }
    class Unique1
    {
        static void Main(string[] args)
        {
            string s = "Thinkquotient";
            string s2 = "";
            foreach(char ch in s)
            {
               // if (!s2.Contains(ch))
                   if(s2.Contains(ch)==false)
                   s2 = s2 + ch;
                Console.WriteLine(ch);

            }
        }
    }

              

            
        
    
}
