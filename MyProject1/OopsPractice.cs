 using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class OopsPractice
    { 
        //class :is a blue print in that what is data stores and what are the members operate in class.
        //OBJECT : object is nothing but instance of a class.
    }
    class Pen
    {
        Refill r;
        int capLength;
        string brand;
        public Pen()
        {

        }
        public Pen(Refill r, int capLength, string brand)
        {
            this.r = r;
            this.capLength = capLength;

            this.brand = brand;
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
        public int CapLength
        {
            set { capLength = value; }
            get { return capLength; }
        }
        public string Brand

        {
            set { brand = value; }
            get { return brand; }
        }
    }
    class Refill
    {
    string inkcolor;
    int length;
    string nib;
    public Refill()
    {

    }
    public Refill(string inkcolor, int length, string nib)
    {
        this.inkcolor = inkcolor;
        this.length = length;
        this. nib = nib;
    }
    public string Inkcolor
    {
        set { inkcolor = value; }
        get { return inkcolor; }
    }
    public int Length
    {
        set { length = value; }
        get { return length; }
    }
    public string Nib
    {
        set { nib = value; }
        get { return nib; }
    }

}



class Nib
{
    string materialType;
    int width;
    public Nib()
    {

    }
    public Nib(string materialType, int width)
    {
        this.materialType = materialType;
        this.width = width;
    }
    public string MaterialType
    {
        set { materialType = value; }
        get { return materialType; }
    }
    public int Width
    {
        set { width = value; }
        get { return width; }
    }




}
    class PenTest
    {
        static void Main(string[] args)
        {
            Refill r1 = new Refill("Red", 10, "Tip");
            Nib n1 = new Nib("Plastic", 5);
            // Pen p1 = new Pen("R", 5, "Trimax",new Refill("Red",10,"Tip", new Nib("Plastic" ,5)));
          //   Pen p1 = new Pen("R" ,5 , "Cello" r1,n1);
          //  Console.WriteLine(p1.r1.Inkcolor);
          //  Console.WriteLine(p1.r1.Length);

        }
    }
}

    
 



  




    
       
   

