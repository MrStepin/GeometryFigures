using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace GeometryFigures
{
    class Circle : Shape
    {
        
        double Radius { get; set; }
        double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Pi * Math.Pow(Radius, 2);
        }

    }
}
