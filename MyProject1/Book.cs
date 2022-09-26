using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Book
    {
        string bookname;
        int price;
        string authorname;

        public string Bookname
        {
            set { bookname = value; }
            get { return bookname; }
        }

            public int Price
        {
            set { Price = value; }
            get { return Price; }
        }

        public string AuthorName
        {
            set { authorname = value; }
            get { return authorname; }
        }
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.bookname = "Rich Dad Poor Dad";
            b1.price = 500;
            b1.authorname = " Robert Kiyosaki";
                Console.WriteLine(b1.bookname);
            Console.WriteLine(b1.price);
            Console.WriteLine(b1.authorname);
        }
    }
}
