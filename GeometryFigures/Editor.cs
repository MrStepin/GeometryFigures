using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Editor
    {
        private List<Shape> _figures;

        public void AddFigure(Shape newFigure, List<Shape> _figures)
        {
            
            _figures.Add(newFigure);

        }

        public void MoveAllFigures(List<Shape> _figures)
        {
            foreach (var figure in _figures)
            
                figure.ChangeCoordinates(5, 0);
            
        }

        public void RemoveFigure(int numberOfFigure, List<Shape> _figures)
        {
            _figures.RemoveAt(numberOfFigure);
        }


        public void SumOfAreas(List<Shape> _figures)
        {
            double sumOfAreas = 0;
            foreach (var figure in _figures)
            {
                double figureArea = figure.Area();
                sumOfAreas += figureArea;
            }
            Console.WriteLine(sumOfAreas);
        }

        public void ListOfFigures(List<Shape> _figures)
        {
            int num = 1;
            foreach (var figure in _figures)
            {
                Console.WriteLine(num + ". " + figure);
                num += 1;
            }
        }
    }
}
