using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class IsEven
    { 
        public bool isEven(int nm)
        {
            if (nm % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            IsEven e = new IsEven();
            int num = int.Parse(Console.ReadLine());
            bool result = e.isEven(num);
            Console.WriteLine(result);
        }
    }
}
