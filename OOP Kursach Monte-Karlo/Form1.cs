using System;
using System.Windows.Forms;

namespace OOP_Kursach_Monte_Karlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            Point dPoint, ePoint, aPoint;

            if (!initializePoints(out dPoint, out ePoint, out aPoint))
            {
                return;
            }

            BorderFigure figure = new BorderFigure(dPoint, ePoint, aPoint);
            MonteCarlo monteCarlo = new MonteCarlo(figure);

            TimeSpan time;
            double calculationError;
            int pointsInside;

            for (uint i = 0; i < 5; i++)
            {
                dataGridView.Rows.Add("10^" + (3 + i), monteCarlo.calculateSquareMC((int)Math.Pow(10, 3 + i), out pointsInside, out time, out calculationError), pointsInside, time, calculationError + " %");
            }

            dataGridView.Rows.Add();
            dataGridView.Rows.Add("Площадь фигуры", figure.actualSquare());
        }


        private bool initializePoints(out Point dPoint, out Point ePoint, out Point aPoint)
        {
            bool ifValidValues = true;
            string[] temp;

            string errorString = "";


            try
            {
                temp = dPoint_textBox.Text.Split(new char[] { ' ', ',' });
                dPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));
            }
            catch
            {
                dPoint = null;
                errorString += "Некорректное значение точки d;\n";
                ifValidValues = false;
            }

            try
            {
                temp = ePoint_textBox.Text.Split(new char[] { ' ', ',' });
                ePoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));
            }
            catch
            {
                ePoint = null;
                errorString += "Некорректное значение точки e;\n";
                ifValidValues = false;
            }

            try
            {
                temp = aPoint_textBox.Text.Split(new char[] { ' ', ',' });
                aPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));
            }
            catch
            {
                aPoint = null;
                errorString += "Некорректное значение точки a;\n";
                ifValidValues = false;
            }

            if (ifValidValues)
            {
                if (aPoint.Y != dPoint.Y)
                {
                    ifValidValues = false;
                    errorString += "Точки a и d должны находится на одном уровне по y;\n";
                }
                if (aPoint.Y >= ePoint.Y)
                {
                    ifValidValues = false;
                    errorString += "Точка a должна быть ниже точки e по оси y;\n";
                }
                if (aPoint.X >= ePoint.X)
                {
                    ifValidValues = false;
                    errorString += "Точка a должна быть правее точки e по оси x;\n";
                }
                if ((ePoint.Y - aPoint.Y) != (dPoint.X - ePoint.X))
                {
                    ifValidValues = false;
                    errorString += "Радиус окружност по оси y должен быть равен радиусу по оси x;\n";
                }
            }

            if (!ifValidValues)
            {
                MessageBox.Show(errorString);
            }

            return ifValidValues;
        }
    }
}
