using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kursach_Monte_Karlo
{
    class MonteCarlo
    {
        private readonly BorderFigure _mainFigure;

        public MonteCarlo (BorderFigure borderFigure)
        {
            _mainFigure = borderFigure;
        }

        public double CalculateSquare(int numberOfPoints)
        {
            Random random = new Random();

            var insidePointCounter = 0;
            for (uint j = 0; j < numberOfPoints; j++)
            {
                var randomX = _mainFigure.MinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.MaxX - _mainFigure.MinX);
                var randomY = _mainFigure.MinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (_mainFigure.MaxY - _mainFigure.MinY);

                if (_mainFigure.isInside(new Point(randomX, randomY)) == true)
                {
                    insidePointCounter++;
                }
            }

            return _mainFigure.RectangleSquare * insidePointCounter / numberOfPoints;
        }
    }
    
}
