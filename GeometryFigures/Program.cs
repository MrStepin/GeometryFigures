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

            Shape userLine = new Line();

            Console.WriteLine("Input radius of circle and click 'Enter':\nFor example 23,6");
            double userRadius = Convert.ToDouble(Console.ReadLine());
            Shape userCircle = new Circle(userRadius);
            Console.WriteLine("Input side of square and click 'Enter':\nFor example 23,6");
            double userSide = Convert.ToDouble(Console.ReadLine());
            Shape userSquare = new Circle(userSide);
            Console.WriteLine("Input base of triangle and click 'Enter':\nFor example 23,6");
            double userA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input height of triangle and click 'Enter':\nFor example 23,6");
            double userH = Convert.ToDouble(Console.ReadLine());
            Shape userTriangle = new Triangle(userA, userH);

            double sumOfAreas = userCircle.Area() + userSquare.Area() + userTriangle.Area() + userLine.Area();
            Console.WriteLine("sum of areas is:" + sumOfAreas);
            

            Shape addFigure = new Circle(1);
            Console.WriteLine("Method for adding figure:");
            addFigure.AddFigure();

            List<Shape> figures = new List<Shape>() { };

            figures.Add(new Triangle(userA, userH));
            figures.Add(new Square(userSide));
            figures.Add(new Circle(userRadius));
            figures.Add(new Line());

            Console.WriteLine("List of figures:");
            int num = 1;
            foreach (var figure in figures)
            {
                Console.WriteLine(num + ". " + figure);
                num += 1;
            }


            void MoveAllFigures(int x, int y)
            {
                foreach (var shape in figures)
                    shape.ChangeCoordinates(x, y);

            }

            Console.WriteLine("If you need to remove figure, enter number:");
            int numberOfFigure = Convert.ToInt16(Console.ReadLine());

            figures.RemoveAt(numberOfFigure);

            Console.ReadKey();
        }
    }
}
