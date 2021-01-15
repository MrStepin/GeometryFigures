﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Triangle : Shape
    {
        internal double a { get; set; }
        internal double h { get; set; }



        internal Triangle(double A, double H)
        {
            a = A;
            h = H;
        }

        internal override double Area()
        {
            return (a*h)/2;
        }

    }
}