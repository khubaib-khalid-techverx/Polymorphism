using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
