using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input radius of circle and click 'Enter':\nFor example 23,6");
            double userRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input side of square and click 'Enter':\nFor example 23,6");
            double userSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input base of triangle and click 'Enter':\nFor example 23,6");
            double userA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input height of triangle and click 'Enter':\nFor example 23,6");
            double userH = Convert.ToDouble(Console.ReadLine());

            List<Shape> figures = new List<Shape>() { };


            Editor addFigure = new Editor();
            Console.WriteLine("Method for adding figure:");
            Triangle triangle = new Triangle(userA, userH);
            Square square = new Square(userSide);
            Circle circle = new Circle(userRadius);
            Line line = new Line();
            addFigure.AddFigure(triangle, figures);
            addFigure.AddFigure(square, figures);
            addFigure.AddFigure(circle, figures);
            addFigure.AddFigure(line, figures);


            Console.WriteLine("List of figures:");
            int num = 1;
            foreach (var figure in figures)
            {
                Console.WriteLine(num + ". " + figure);
                num += 1;
            }


            double sumOfAreas = 0;
            Console.WriteLine("sum of areas is:");
            foreach (var figure in figures)
            {
                double figureArea = figure.Area();
                sumOfAreas += figureArea;
            }
            Console.WriteLine(sumOfAreas);


            Editor moveFigure = new Editor();
            foreach (var shape in figures)
            {
                moveFigure.MoveAllFigures(figures);
            }


            Editor removeFigure = new Editor();
            Console.WriteLine("If you need to remove figure, enter number:");
            int numberOfFigure = Convert.ToInt32(Console.ReadLine());
            removeFigure.RemoveFigure(numberOfFigure, figures);


            Console.ReadKey();
        }
    }
}
