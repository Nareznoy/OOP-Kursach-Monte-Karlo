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

        public double calculateSquareMC(int numberOfPoints, out int insidePointsCounter, out TimeSpan time, out double calculationError)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            insidePointsCounter = 0;

            stopwatch.Start();

            for (uint j = 0; j < numberOfPoints; j++)
            {
                var randomX = _mainFigure.MinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.MaxX - _mainFigure.MinX);
                var randomY = _mainFigure.MinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.MaxY - _mainFigure.MinY);

                if (_mainFigure.isInside(new Point(randomX, randomY)) == true)
                {
                    insidePointsCounter++;
                }
            }

            double square = Math.Round((_mainFigure.RectangleSquare * insidePointsCounter / numberOfPoints), 3);

            stopwatch.Stop();

            calculationError = Math.Round((Math.Abs(square - _mainFigure.actualSquare()) / _mainFigure.actualSquare()) * 100, 2);

            time = stopwatch.Elapsed;
            
            return square;
        }
    }
    
}
