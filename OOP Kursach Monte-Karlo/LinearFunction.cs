using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class LinearFunction : BorderFunctions
    {
        Point _firstPoint;
        Point _secondPoint;

        private double _k;
        private double _b;

        public LinearFunction(Point firstPoint, Point secondPoint)
        {
            _firstPoint = firstPoint;
            _secondPoint = secondPoint;

            _k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            _b = firstPoint.Y - _k * firstPoint.X;
        }

        public override bool IsInside(double x, double y)
        {
            return (y < (_k * x + _b)) ? true : false;
        }

        public override double Square()
        {
            return (_secondPoint.X - _firstPoint.X) * (_secondPoint.Y - _firstPoint.Y) / 2;
        }
    }
}
