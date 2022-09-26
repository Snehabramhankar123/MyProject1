using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ARRAYPrograms
{
    class Library
    {
        string shelves;

         public Library()
         {

         }
         public Library(string shelves)
         {
            this.shelves = shelves;
         }  
    }
   class Books
   {
        string title;
        string authorname;
        int bookid;
        public Books()
        {

        }
        public Books(string title, string authorname, int bookid)
        {
            this.title = title;
            this.authorname = authorname;
            this.bookid = bookid;
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Authorname
        {
            set {authorname = value; }
            get { return authorname; }
        }
        public int Bookid
        {
            set { bookid = value; }
            get { return bookid; }
        }

        static void Main(string[] args)
        {
            Books b1 = new Books();
            Library l1 = new Library();
            b1.Authorname = "Sachin Sir";
            Console.WriteLine(b1.Authorname);
        }

   }
        

}
