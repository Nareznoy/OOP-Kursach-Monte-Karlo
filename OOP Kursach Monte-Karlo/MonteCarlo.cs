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

        public double calculateSquareMC(int numberOfPoints, out int insidePointsCounter, out long timeMilliseconds, out double calculationError)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            insidePointsCounter = 0;

            stopwatch.Restart();

            for (uint j = 0; j < numberOfPoints; j++)
            {
                double randomX = _mainFigure.getMinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.getMaxX - _mainFigure.getMinX);
                double randomY = _mainFigure.getMinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.getMaxY - _mainFigure.getMinY);

                if (_mainFigure.isInside(randomX, randomY) == true)
                {
                    insidePointsCounter++;
                }
            }

            double square = Math.Round((_mainFigure.RectangleSquare * insidePointsCounter / numberOfPoints), 3);

            calculationError = Math.Round((Math.Abs(square - _mainFigure.RealSquare) / _mainFigure.RealSquare) * 100, 2);

            stopwatch.Stop();

            timeMilliseconds = stopwatch.ElapsedMilliseconds;
            
            return square;
        }
    }
    
}
