using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.StringDEMO
{
    class HighestFrequencyString
    {


        static bool isAlreadyPresent(string s, int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (s[i] == s[current])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s= Console.ReadLine();
           // string s = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (isAlreadyPresent(s, i) == false)
                {
                    int c = 1; 
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            c++;
                            
                        }

                    }
                    Console.WriteLine($"Frequency of {s[i]}={c}");
                   // Console.WriteLine($"Max Frequency {s[i]}={maxf++}");
                }
            }
        }
    }
            
        
        
}
