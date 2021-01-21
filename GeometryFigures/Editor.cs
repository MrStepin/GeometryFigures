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

        public Editor()
        {
             _figures = new List<Shape> { };
        }

        public void AddFigure(Shape newFigure)
        {
            
            _figures.Add(newFigure);

        }

        public void MoveAllFigures()
        {
            foreach (var figure in _figures)
            
                figure.ChangeCoordinates(5, 0);
            
        }

        public void RemoveFigure(int numberOfFigure)
        {
            _figures.RemoveAt(numberOfFigure);
        }


        public void SumOfAreas()
        {
            double sumOfAreas = 0;
            foreach (var figure in _figures)
            {
                double figureArea = figure.Area();
                sumOfAreas += figureArea;
            }
            Console.WriteLine(sumOfAreas);
        }

        public void ListOfFigures()
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
