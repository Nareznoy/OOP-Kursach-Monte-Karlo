using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class BorderFigure
    {
        //private Point _dPoint;
        //private Point _ePoint;
        //private Point _aPoint;

        LinearFunction _linearFunction;
        Circle _circle;

        private double _minX;
        private double _minY;

        private double _maxX;
        private double _maxY;

        private double _rectangleSquare;


        //private Circle _centerCircle;
        //private double _k;
        //private double _b;

        //private int functionsIsCalculated = 0;


        public double MinX { get { return _minX; } set { _minX = value; } }
        public double MinY { get { return _minY; } set { _minY = value; } }

        public double MaxX { get { return _maxX; } set { _maxX = value; } }
        public double MaxY { get { return _maxY; } set { _maxY = value; } }

        public double RectangleSquare { get { return _rectangleSquare; } set { _rectangleSquare = value; } }


        public BorderFigure(Point dPoint, Point ePoint, Point aPoint)
        {
            //this._dPoint = new Point(dPoint.X, dPoint.Y);
            //this._ePoint = new Point(ePoint.X, ePoint.Y);
            //this._aPoint = new Point(aPoint.X, aPoint.Y);

            _minX = aPoint.X;
            _minY = aPoint.Y;

            _maxX = dPoint.X;
            _maxY = ePoint.Y;

            _linearFunction = new LinearFunction(aPoint, ePoint);
            _circle = new Circle(new Point(ePoint.X, ePoint.Y - (ePoint.Y - dPoint.Y)), ePoint.Y - dPoint.Y);

            calculateRectangleSquare();
        }


        //public void calculateLinearCoeffs()
        //{
        //    _k = (_ePoint.Y - _aPoint.Y) / (_ePoint.X - _aPoint.X);
        //    _b = _aPoint.Y - _k * _aPoint.X;

        //    functionsIsCalculated++;
        //}


        //public void calculateCircle()
        //{
        //    _centerCircle = new Circle(new Point(_ePoint.X, _ePoint.Y - (_ePoint.Y - _dPoint.Y)), _ePoint.Y - _dPoint.Y);

        //    functionsIsCalculated++;
        //}


        public bool isInside(Point newPoint)
        {
            //if (functionsIsCalculated != 2)
            //{
            //    Console.WriteLine("stuff is not set!");

            //    return false;
            //}

            if (newPoint.X < _circle.X)
                return _linearFunction.IsInside(newPoint.X, newPoint.Y);
            else
                return _circle.IsInside(newPoint.X, newPoint.Y);
        }


        //private bool isLowerlinearFunction(double x, double y)
        //{
        //    return (y < (_k * x + _b)) ? true : false;
        //}


        //private bool isInsideCircle(double x, double y)
        //{
        //    return ((Math.Sqrt((x - _centerCircle.X) * (x - _centerCircle.X) + y * y)) <= _centerCircle.Radius) ? true : false;
        //}


        public double actualSquare()
        {
            //return ((_circle.X - aPoint.X) * _centerCircle.Radius / 2) +
            //       (Math.PI * _centerCircle.Radius * _centerCircle.Radius / 4);
            return _circle.Square() + _linearFunction.Square();
        }


        public void calculateRectangleSquare()
        {
            _rectangleSquare = (_maxX - _minX) * (_maxY - _minY);
        }
    }
}
