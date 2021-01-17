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


            Editor ListOfFigures = new Editor();


            Console.WriteLine("List of figures:");
            int num = 1;
            foreach (var figure in ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius))
            {
                Console.WriteLine(num + ". " + figure);
                num += 1;
            }


            double sumOfAreas = 0;
            Console.WriteLine("sum of areas is:");
            foreach (var figure in ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius))
            {
                double figureArea = figure.Area();
                sumOfAreas += figureArea;
            }
            Console.WriteLine(sumOfAreas);


            Editor newFigure = new Editor();
            Editor addFigure = newFigure;
            Console.WriteLine("Method for adding figure:");
            addFigure.AddFigure(ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius));


            Editor moveFigure = new Editor();
            foreach (var shape in ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius))
            {
                moveFigure.MoveAllFigures(ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius));
            }
                    
            

            Console.WriteLine("If you need to remove figure, enter number:");
            int numberOfFigure = Convert.ToInt32(Console.ReadLine());
            ListOfFigures.ListOfShapes(userA, userH, userSide, userRadius).RemoveAt(numberOfFigure);


            Console.ReadKey();
        }
    }
}
