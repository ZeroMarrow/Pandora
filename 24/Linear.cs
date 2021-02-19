using System;
using System.Collections.Generic;
using System.Text;

namespace _24
{
    class Linear:Root
    {
        private double numberres;
        public double Z { get; set; }
        public double Resss { get; set; }
        public Linear(double numberres, double num, double z, double resss) : base(numberres, num)
        {
            Z = z;
            Resss = resss = z / numberres;
        }
        public override void Display()
        {
            Console.WriteLine("Число:" + Num + " Корень:" + Numberres + " Z=" + Z + " Результат:" + Resss);
        }
        public override double Numberres
        {
            get { return +numberres; }
            set { numberres = value; }
        }
    }
}
