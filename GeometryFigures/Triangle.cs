using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Triangle : Shape
    {
         double a { get; set; }
        double h { get; set; }



        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }

        public override double Area()
        {
            return (a*h)/2;
        }

    }
}
