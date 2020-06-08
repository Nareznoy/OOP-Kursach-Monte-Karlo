namespace KR_OOP_Monte_Karlo
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }


        public Point(double newX, double newY)
        {
            X = newX;
            Y = newY;
        }

        public Point(Point previousPoint)
        {
            X = previousPoint.X;
            Y = previousPoint.Y;
        }
    }
}