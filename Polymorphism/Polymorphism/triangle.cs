using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }
}
