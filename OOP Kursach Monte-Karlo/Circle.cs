using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class Circle : BorderFunctions
    {
        public Point CenterPoint { get; }
        public double Radius { get; set; }


        public Circle(Point center, double newRadius)
        {
            CenterPoint = new Point(center);
            Radius = newRadius;
        }


        public override bool IsInside(double x, double y)
        {
            return ((Math.Sqrt((x - CenterPoint.X) * (x - CenterPoint.X) + y * y)) <= Radius) ? true : false;
        }


        public override double Square()
        {
            return Math.PI * Radius * Radius / 4;
        }
    }
}