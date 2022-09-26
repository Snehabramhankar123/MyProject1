using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Book1
    {
        string booktitle;
        double price;
        string authorname;
        public Book1(string booktitle,double price,string authorname)
        {
            this.booktitle = booktitle;
            this.price = price;
            this.authorname = authorname;
        }
        public string Booktitle
        {
            set { booktitle = value; }
            get { return booktitle; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }

        }
        public string Authorname
        {
            set { authorname = value; }
            get { return authorname; }

        }
        static void Main(string[] args)
        {
            Book1 b = new Book1("developing java software"    ,79.5,   "Russel Winderand");
            Console.WriteLine(b.booktitle + b.price + b.authorname);
        }
    
       
    }
}
