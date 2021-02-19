using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            Linear a = new Linear(11, 6, 5, 1);
            a.Display();
            Square s = new Square(1, 4, 2, 1, 1, 1, 1, 1, 1, 1);
            s.Display();
        }
    }
}
