using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test10SeptOOPS
{
    class Box
    { 
        public void Dimension()
        {

        }
    }
    class  cube : Box
    {
        public void Dimension ()
        {
            Console.WriteLine("Cube have Eqaul Dimensions");
        }
    }
    class Cuboid : Box
    {
        public void Dimension ()
        {
            Console.WriteLine("Cubiod  having varying Dimensions");

        }
    }
}
