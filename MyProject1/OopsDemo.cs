using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MovieName
    { public string Movie
        {
            set {   Movie = value; }
            get { return Movie; }
        }
        public string Actor
        {
            set { Actor = value; }
            get { return Actor; }
        }
        public double  Rating
        {
            set { Rating = value; }
            get { return Rating; }
        }
        static void Main(string[] args)
        {
            MovieName m1 = new MovieName();
            m1.Movie = "Shivaji The Boss";
            m1.Actor = "Rajnikant";
            m1.Rating = 4.5;
            Console.WriteLine(m1.Movie);
            Console.WriteLine(m1.Actor);
            Console.WriteLine(m1.Rating);

        }
    }
}
