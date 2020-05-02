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
        //private static double r_;

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
        }


        public static void calculateLinearCoeffs(Point firstPoint, Point secondPoint)
        {
            _b = (secondPoint.Y * firstPoint.X - secondPoint.X * firstPoint.Y) / (-secondPoint.X + 1);
            if ((firstPoint.X != 0 && firstPoint.Y != 0) || (firstPoint.X != 0))
                _k = (firstPoint.Y - _b) / firstPoint.X;
            else
            {
                if (firstPoint.Y != 0)
                    _k = (firstPoint.Y - _b);
                else
                    _k = 1;
            }

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
            return ((Math.Sqrt(x * x + y * y) - _centerCircle.X) < _centerCircle.Radius) ? true : false;
        }


        public static double calculateActualSquare(Point leftDown)
        {
            return ((_centerCircle.X - leftDown.X) * _centerCircle.Radius / 2) +
                   (Math.PI * _centerCircle.Radius * _centerCircle.Radius / 4);
        }
    }
}
