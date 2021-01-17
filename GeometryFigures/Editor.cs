using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Editor
    {
        public List<GeometryFigures.Shape> ListOfShapes(double userA, double userH, double userSide, double userRadius)
        {
            List<Shape> figures = new List<Shape>() { };
            figures.Add(new Triangle(userA, userH));
            figures.Add(new Square(userSide));
            figures.Add(new Circle(userRadius));
            figures.Add(new Line());

            return figures;
        }


        public void AddFigure(List<GeometryFigures.Shape> ListOfShapes)
        {
            GeometryFigures.Shape figure = null;
            ListOfShapes.Add(figure);
            Console.WriteLine("Done");
        }

        public void MoveAllFigures(List<GeometryFigures.Shape> listOfShapes)
        {
            foreach (var figure in listOfShapes)
            
                figure.ChangeCoordinates(5, 0);
            
        }

    }
}
