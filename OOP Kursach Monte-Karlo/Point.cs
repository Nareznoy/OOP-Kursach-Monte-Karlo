using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    public class Point
    {
        private double _x;
        private double _y ;


        public double X
        {
            get => _x;
            set => _x = value;
        }


        public double Y
        {
            get => _y;
            set => _y = value;
        }


        public Point(double newX, double newY)
        {
            _x = newX;
            _y = newY;
        }
    }
}