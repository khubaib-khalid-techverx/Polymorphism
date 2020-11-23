using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new triangle();
            s.draw();

        }
    }
}
