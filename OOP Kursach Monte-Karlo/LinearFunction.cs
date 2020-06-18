namespace KR_OOP_Monte_Karlo
{
    class LinearFunction : BorderFunctions
    {
        public Point FirstPoint { get; }
        public Point SecondPoint { get; }

        private readonly double _k;
        private readonly double _b;


        public LinearFunction()
        {
            FirstPoint = new Point();
            SecondPoint = new Point();

            _k = 0;
            _b = 0;
        }

        public LinearFunction(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;

            _k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            _b = firstPoint.Y - _k * firstPoint.X;
        }

        public LinearFunction(LinearFunction previousLinearFunction)
        {
            FirstPoint = new Point(previousLinearFunction.FirstPoint);
            SecondPoint = new Point(previousLinearFunction.SecondPoint);

            _k = previousLinearFunction._k;
            _b = previousLinearFunction._b;
        }

        public override bool isInside(double x, double y)
        {
            return (y < (_k * x + _b)) ? true : false;
        }

        public override double square()
        {
            return (SecondPoint.X - FirstPoint.X) * (SecondPoint.Y - FirstPoint.Y) / 2;
        }
    }
}
