using System;

namespace KR_OOP_Monte_Karlo
{
    class Circle : BorderFunctions
    {
        public Point CenterPoint { get; }
        public double Radius { get; }


        public Circle(Point center, double newRadius)
        {
            CenterPoint = new Point(center);
            Radius = newRadius;
        }


        public override bool isInside(double x, double y)
        {
            return (((x - CenterPoint.X) * (x - CenterPoint.X) + (y - CenterPoint.Y) * (y - CenterPoint.Y)) <= Radius * Radius) ? true : false;
        }


        public override double square()
        {
            return Math.PI * Radius * Radius / 4;
        }
    }
}