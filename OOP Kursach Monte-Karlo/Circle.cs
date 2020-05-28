using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class Circle : Point
    {
        public double Radius { get; set; }


        public Circle(Point newCenter, double newRadius) : base(newCenter.X, newCenter.Y)
        {
            Radius = newRadius;
        }

        public override bool IsInside(double x, double y)
        {
            return ((Math.Sqrt((x - _x) * (x - _x) + y * y)) <= Radius) ? true : false;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius / 4;
        }
    }
}