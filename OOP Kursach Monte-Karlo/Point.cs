﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    public class Point : BorderFunctions
    {
        protected double _x;
        protected double _y ;


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

        public Point(Point previousPoint)
        {
            _x = previousPoint._x;
            _y = previousPoint._y;
        }

        public override bool IsInside(double x, double y)
        {
            throw new NotImplementedException();
        }

        public override double Square()
        {
            throw new NotImplementedException();
        }
    }
}