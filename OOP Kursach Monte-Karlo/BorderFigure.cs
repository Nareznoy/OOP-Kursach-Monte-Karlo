using System.Windows.Forms;

namespace KR_OOP_Monte_Karlo
{
    class BorderFigure
    {
        private readonly LinearFunction _linearFunction;
        private readonly Circle _circle;

        public double RectangleSquare { get; }
        public double RealSquare { get; }

        public double getMinX => _linearFunction.FirstPoint.X;
        public double getMaxX => _circle.CenterPoint.X + _circle.Radius;

        public double getMinY => _circle.CenterPoint.Y;
        public double getMaxY => _circle.CenterPoint.Y + _circle.Radius;


        public BorderFigure()
        {
            _linearFunction = new LinearFunction();
            _circle = new Circle();

            RectangleSquare = 0;
            RealSquare = 0;
        }

        public BorderFigure(Point ePoint, Point aPoint)
        {
            _linearFunction = new LinearFunction(aPoint, ePoint);
            _circle = new Circle(new Point(ePoint.X, ePoint.Y - (ePoint.Y - aPoint.Y)), ePoint.Y - aPoint.Y);

            RectangleSquare = (ePoint.X + _circle.Radius - aPoint.X) * (ePoint.Y - aPoint.Y);
            RealSquare = _circle.square() + _linearFunction.square();
        }

        public BorderFigure(BorderFigure previousBorderFigure)
        {
            _linearFunction = new LinearFunction(previousBorderFigure._linearFunction);
            _circle = new Circle(previousBorderFigure._circle);

            RectangleSquare = previousBorderFigure.RectangleSquare;
            RealSquare = previousBorderFigure.RealSquare;
        }


        public bool isInside(double x, double y)
        {
            if (x < _linearFunction.SecondPoint.X)
                return _linearFunction.isInside(x, y);
            else
                return _circle.isInside(x, y);
        }
    }
}
