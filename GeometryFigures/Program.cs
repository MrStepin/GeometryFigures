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


            Editor editor = new Editor();
            Console.WriteLine("Method for adding figure:");
            Triangle triangle = new Triangle(userA, userH);
            Square square = new Square(userSide);
            Circle circle = new Circle(userRadius);
            Line line = new Line();
            editor.AddFigure(triangle, figures);
            editor.AddFigure(square, figures);
            editor.AddFigure(circle, figures);
            editor.AddFigure(line, figures);


            Console.WriteLine("List of figures:");
            editor.ListOfFigures(figures);


            Console.WriteLine("sum of areas is:");
            editor.SumOfAreas(figures);


            editor.MoveAllFigures(figures);


            Console.WriteLine("If you need to remove figure, enter number:");
            int numberOfFigure = Convert.ToInt32(Console.ReadLine());
            editor.RemoveFigure(numberOfFigure, figures);


            Console.ReadKey();
        }
    }
}
