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
        internal abstract double Area();

        public void ChangeCoordinates(int x, int y)
        {
            x += 5;
            y += 5;
        }

        public void AddFigure()
        {
         Console.WriteLine("Done");
        }

    }
}
