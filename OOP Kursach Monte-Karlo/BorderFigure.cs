namespace OOP_Kursach_Monte_Karlo
{
    class BorderFigure
    {
        private readonly LinearFunction _linearFunction;
        private readonly Circle _circle;


        public double MinX { get; }
        public double MinY { get; }

        public double MaxX { get; }
        public double MaxY { get; }

        public double RectangleSquare { get; }


        public BorderFigure(Point dPoint, Point ePoint, Point aPoint)
        {
            MinX = aPoint.X;
            MinY = aPoint.Y;

            MaxX = dPoint.X;
            MaxY = ePoint.Y;

            _linearFunction = new LinearFunction(aPoint, ePoint);
            _circle = new Circle(new Point(ePoint.X, ePoint.Y - (ePoint.Y - dPoint.Y)), ePoint.Y - dPoint.Y);

            RectangleSquare = (MaxX - MinX) * (MaxY - MinY);
        }


        public bool isInside(Point newPoint)
        {
            if (newPoint.X < _linearFunction.SecondPoint.X)
                return _linearFunction.IsInside(newPoint.X, newPoint.Y);
            else
                return _circle.IsInside(newPoint.X, newPoint.Y);
        }


        public double actualSquare()
        {
            return _circle.Square() + _linearFunction.Square();
        }
    }
}
