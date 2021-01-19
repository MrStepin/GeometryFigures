using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Square : Shape
    {
        double Side { get; set; }


        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

    }
}
