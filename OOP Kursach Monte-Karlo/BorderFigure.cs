namespace KR_OOP_Monte_Karlo
{
    class BorderFigure
    {
        private readonly LinearFunction _linearFunction;
        private readonly Circle _circle;

        public double RectangleSquare { get; }

        public double getMinX => _linearFunction.FirstPoint.X;
        public double getMaxX => _circle.CenterPoint.X + _circle.Radius;

        public double getMinY => _circle.CenterPoint.Y;
        public double getMaxY => _circle.CenterPoint.Y + _circle.Radius;

        public BorderFigure(Point ePoint, Point aPoint)
        {
            _linearFunction = new LinearFunction(aPoint, ePoint);
            _circle = new Circle(new Point(ePoint.X, ePoint.Y - (ePoint.Y - aPoint.Y)), ePoint.Y - aPoint.Y);

            RectangleSquare = (ePoint.X + _circle.Radius - aPoint.X) * (ePoint.Y - aPoint.Y);
        }


        public bool isInside(Point newPoint)
        {
            if (newPoint.X < _linearFunction.SecondPoint.X)
                return _linearFunction.isInside(newPoint.X, newPoint.Y);
            else
                return _circle.isInside(newPoint.X, newPoint.Y);
        }


        public double actualSquare()
        {
            return _circle.square() + _linearFunction.square();
        }
    }
}
