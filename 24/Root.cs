using System;
using System.Collections.Generic;
using System.Text;

namespace _24
{
    abstract class Root
    {
        public abstract double Numberres { get; set; }
        public double Num { get; set; }
        protected Root(double numberres,double num)
        {
            Numberres = numberres = Math.Sqrt(num);
            Num = num;
        }
        public abstract void Display();
    }
}
