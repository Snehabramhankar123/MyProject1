using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class ArrayDemo2D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row size");
            int rs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coulumn Size");
            int cs = int.Parse(Console.ReadLine());
            int[,] a = new int[rs, cs];
            for(int r=0; r< a.GetLength(0);r++)
            {
                Console.WriteLine("Enter"+ a.GetLength(1)+"Elements for rowsize" +r);
                for(int c=0; c< a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());

                }
            }
            for(int r=0; r< a.GetLength(0);r++ )
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

           // int max = arr[0, 0];
           // for(int r=0; r< arr.GetLength; r++)
            {

            }

        }
    }
}
