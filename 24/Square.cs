using System;
using System.Collections.Generic;
using System.Text;

namespace _24
{
    class Square:Root
    {
        private double numberres;
        public double A;
        public double B;
        public double C;
        public double D;
        public double D1;
        public double X1;
        public double X2;
        public Square(double a, double b, double c, double resschet, double d1, double d, double x1, double x2, double numberres, double num) : base(numberres, num)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            D1 = d1;
            D = d = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                num = d;
                resschet = d1;
                X1 = x1 = (-b * d1) / (2 * a);
                X2 = x2 = (-b - d1) / (2 * a);
            }
            else Console.WriteLine("Действительных корней нет");
        }
        public override void Display()
        {
            Console.WriteLine("A="+A+" B="+B+" C="+C+" D="+D+" X1="+X1+" X2="+X2);
        }
        public override double Numberres
        {
            get { return +numberres; }
            set { numberres = value; }
        }
    }
}
