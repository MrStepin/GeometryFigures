using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Square : Shape
    {
        internal double Side { get; set; }


        internal Square(double side)
        {
            Side = side;
        }

        internal override double Area()
        {
            return Math.Pow(Side, 2);
        }

    }
}
