using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class LinearFunction : BorderFunctions
    {
        public Point FirstPoint { get; }
        public Point SecondPoint { get; }

        private readonly double _k;
        private readonly double _b;

        public LinearFunction(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;

            _k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            _b = firstPoint.Y - _k * firstPoint.X;
        }

        public override bool IsInside(double x, double y)
        {
            return (y < (_k * x + _b)) ? true : false;
        }

        public override double Square()
        {
            return (SecondPoint.X - FirstPoint.X) * (SecondPoint.Y - FirstPoint.Y) / 2;
        }
    }
}
