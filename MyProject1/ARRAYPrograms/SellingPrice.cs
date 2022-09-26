
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class SellingPrice
    {
        static void calsellingprice(int costprice, int profit , int no_of_item)
        {
            int sellingprice = costprice + (profit / 100) * costprice;
            Console.WriteLine(sellingprice);
        }
        static void Main(string[] args)
        {
            int costprice = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());
            int no_of_item = int.Parse(Console.ReadLine());
            calsellingprice(costprice, profit, no_of_item);
        }
    }
}
