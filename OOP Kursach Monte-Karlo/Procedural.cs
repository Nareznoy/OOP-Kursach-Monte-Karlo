using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach_Monte_Karlo
{
    class Procedural
    {
        private Point _dPoint;
        private Point _ePoint;
        private Point _aPoint;

        private double _minX;
        private double _minY;

        private double _maxX;
        private double _maxY;

        private double _rectangleSquare;


        private Circle _centerCircle;
        private double _k;
        private double _b;

        private int functionsIsCalculated = 0;


        Random random = new Random();


        public double MinX { get { return _minX; } set { _minX = value; } }
        public double MinY { get { return _minY; } set { _minY = value; } }

        public double MaxX { get { return _maxX; } set { _maxX = value; } }
        public double MaxY { get { return _maxY; } set { _maxY = value; } }

        public double RectangleSquare { get { return _rectangleSquare; } set { _rectangleSquare = value; } }


        public List<double> calculate(Point _dPoint, Point _ePoint, Point _aPoint)
        {
            this._dPoint = new Point(_dPoint.X, _dPoint.Y);
            this._ePoint = new Point(_ePoint.X, _ePoint.Y);
            this._aPoint = new Point(_aPoint.X, _aPoint.Y);

            _minX = this._aPoint.X;
            _minY = this._aPoint.Y;

            _maxX = this._dPoint.X;
            _maxY = this._ePoint.Y;

            calculateLinearCoeffs();
            calculateCircle();

            calculateRectangleSquare();

            List<double> squares = new List<double>();

            int insidePointCounter;
            double randomX;
            double randomY;
            for (uint i = 0; i < 5; i++)
            {
                insidePointCounter = 0;
                for (uint j = 0; j < Math.Pow(10, 3 + i); j++)
                {
                    randomX = MinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (MaxX - MinX);
                    randomY = MinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (MaxY - MinY);

                    if (isInside(new Point(randomX, randomY)) == true)
                    {
                        insidePointCounter++;
                    }
                     
                }
                squares.Add(RectangleSquare * insidePointCounter / Math.Pow(10, 3 + i));
            }

            return squares;
        }


        //public void setFigure(Point _dPoint, Point _ePoint, Point _aPoint)
        //{
        //    this._dPoint = new Point(_dPoint.X, _dPoint.Y);
        //    this._ePoint = new Point(_ePoint.X, _ePoint.Y);
        //    this._aPoint = new Point(_aPoint.X, _aPoint.Y);

        //    _minX = this._aPoint.X;
        //    _minY = this._aPoint.Y;

        //    _maxX = this._dPoint.X;
        //    _maxY = this._ePoint.Y;

        //    calculateLinearCoeffs();
        //    calculateCircle();

        //    calculateRectangleSquare();
        //}


        public void calculateLinearCoeffs()
        {
            _k = (_ePoint.Y - _aPoint.Y) / (_ePoint.X - _aPoint.X);
            _b = _aPoint.Y - _k * _aPoint.X;

            functionsIsCalculated++;
        }


        public void calculateCircle()
        {
            _centerCircle = new Circle(new Point(_ePoint.X, _ePoint.Y - (_ePoint.Y - _dPoint.Y)), _ePoint.Y - _dPoint.Y);

            functionsIsCalculated++;
        }


        public bool isInside(Point newPoint)
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


        private bool isLowerlinearFunction(double x, double y)
        {
            return (y < (_k * x + _b)) ? true : false;
        }


        private bool isInsideCircle(double x, double y)
        {
            return ((Math.Sqrt((x - _centerCircle.X) * (x - _centerCircle.X) + y * y)) <= _centerCircle.Radius) ? true : false;
        }


        public double actualSquare()
        {
            return ((_centerCircle.X - _aPoint.X) * _centerCircle.Radius / 2) +
                   (Math.PI * _centerCircle.Radius * _centerCircle.Radius / 4);
        }


        public void calculateRectangleSquare()
        {
            _rectangleSquare = (_maxX - _minX) * (_maxY - _minY);
        }   
    }
}
