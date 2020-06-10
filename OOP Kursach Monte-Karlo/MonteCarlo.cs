using System;
using System.Diagnostics;

namespace KR_OOP_Monte_Karlo
{
    class MonteCarlo
    {
        private readonly BorderFigure _mainFigure;

        public MonteCarlo (BorderFigure borderFigure)
        {
            _mainFigure = borderFigure;
        }

        public double calculateSquareMC(int numberOfPoints, out int insidePointsCounter, out int timeMilliseconds, out double calculationError)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            insidePointsCounter = 0;

            stopwatch.Start();

            for (uint j = 0; j < numberOfPoints; j++)
            {
                var randomX = _mainFigure.getMinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.getMaxX - _mainFigure.getMinX);
                var randomY = _mainFigure.getMinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.getMaxY - _mainFigure.getMinY);

                if (_mainFigure.isInside(new Point(randomX, randomY)) == true)
                {
                    insidePointsCounter++;
                }
            }

            double square = Math.Round((_mainFigure.RectangleSquare * insidePointsCounter / numberOfPoints), 3);

            stopwatch.Stop();

            calculationError = Math.Round((Math.Abs(square - _mainFigure.actualSquare()) / _mainFigure.actualSquare()) * 100, 2);

            timeMilliseconds = stopwatch.Elapsed.Milliseconds;
            
            return square;
        }
    }
    
}
