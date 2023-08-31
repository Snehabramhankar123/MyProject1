using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s = "abcde";
            StringBuilder sb = new StringBuilder(s);
           Console.WriteLine(sb.Capacity);
            sb.Append("sneha");
            sb.Append("90"); 
            sb.Append("Deepa");
            sb.Append("Sakshi");
            sb.AppendLine("Rohini");
            sb.Insert(1, "Deepa");
            sb.Remove(1, 5);
            string str = sb.ToString();
            for(int i=0; i<sb.Length;i++)
            {
                if (sb[i] == 'a')
                    sb[i] = '*';
            }
            sb.Replace('e', '@');
            Console.WriteLine(sb);






        }
    }
}
