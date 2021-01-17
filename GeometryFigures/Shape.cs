using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        internal abstract double Area();

        public (int, int) ChangeCoordinates(int x, int y)
        {
            X += x;
            Y += y;
            return (X, Y);

        }

    }
}
