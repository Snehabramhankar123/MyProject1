using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class AverageOfPrimeNumbers
    {
        static void Main(string[] args)
        {
            float sum = 0, count = 0, flag;

            for (int i = 2; i <= 20; i++)
            {
                flag = 0;
                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
                Console.WriteLine("The average of Prime number is: " + (sum / count));
            
        }
    }
        class Prime
        {
            static void Main(string[] args)
            {
                float sum = 0, count = 0, average;
                for (int i = 2; i < 100; i++)
                    for (int j = 2; j <= i; j++)
                    {
                        if (j == i)
                        {
                            sum = sum + i;
                            count++;
                        }
                        else if (i % j == 0)
                        {
                            break;
                        }
                    }
                average = sum / count;
                Console.WriteLine("Average=" + average);


            }
        }
    
}

