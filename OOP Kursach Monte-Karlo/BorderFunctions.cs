using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    static class BorderFunctions
    {
        private static Circle _centerCircle;
        private static double _k;
        private static double _b;

        private static int functionsIsCalculated = 0;


        public static bool isInside(Point newPoint)
        {
            if (functionsIsCalculated != 2)
            {
                Console.WriteLine("stuff is not set!");

                return false;
            }

            if (newPoint.X < _centerCircle.X)
                return isLowerlinearFunction(newPoint.X, newPoint.Y);
            else
                return isInsideCircle(newPoint.X, newPoint.Y);

            functionsIsCalculated = 0;
        }


        public static void calculateLinearCoeffs(Point firstPoint, Point secondPoint)
        {
            _k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            _b = firstPoint.Y - _k * firstPoint.X;

            functionsIsCalculated++;
        }


        private static bool isLowerlinearFunction(double x, double y)
        {
            return (y < (_k * x + _b)) ? true : false;
        }


        public static void calculateCircle(Point ePoint, Point dPoint)
        {
            _centerCircle = new Circle(new Point(ePoint.X, ePoint.Y - (ePoint.Y - dPoint.Y)), ePoint.Y - dPoint.Y);

            functionsIsCalculated++;
        }


        private static bool isInsideCircle(double x, double y)
        {
            return ((Math.Sqrt((x - _centerCircle.X) * (x - _centerCircle.X) + y * y)) <= _centerCircle.Radius) ? true : false;
        }


        public static double calculateActualSquare(Point leftDown)
        {
            return ((_centerCircle.X - leftDown.X) * _centerCircle.Radius / 2) +
                   (Math.PI * _centerCircle.Radius * _centerCircle.Radius / 4);
        }
    }
}
