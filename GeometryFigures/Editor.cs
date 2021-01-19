using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Editor
    {

        public void AddFigure(Shape newFigure, List<Shape> figures)
        {
            
            figures.Add(newFigure);

        }

        public void MoveAllFigures(List<Shape> figures)
        {
            foreach (var figure in figures)
            
                figure.ChangeCoordinates(5, 0);
            
        }

        public void RemoveFigure(int numberOfFigure, List<Shape> figures)
        {
            figures.RemoveAt(numberOfFigure);
        }

    }
}
