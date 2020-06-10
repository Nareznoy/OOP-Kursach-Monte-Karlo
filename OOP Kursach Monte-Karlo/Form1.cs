﻿using System;
using System.Windows.Forms;

namespace KR_OOP_Monte_Karlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!initializePoints(out Point ePoint, out Point aPoint))
            {
                return;
            }

            BorderFigure figure = new BorderFigure(ePoint, aPoint);
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


        private bool initializePoints(out Point ePoint, out Point aPoint)
        {
            bool ifValidValues = true;
            string[] temp;

            string errorString = "";

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
            }

            if (!ifValidValues)
            {
                MessageBox.Show(errorString);
            }

            return ifValidValues;
        }

        private void testCaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (testCaseRadioButton.Checked)
            {
                dPoint_textBox.Text = "20 0";
                ePoint_textBox.Text = "10 10";
                aPoint_textBox.Text = "0 0";

                dPoint_textBox.Enabled = false;
                ePoint_textBox.Enabled = false;
                aPoint_textBox.Enabled = false;
            }
            else
            {
                dPoint_textBox.Clear();
                ePoint_textBox.Clear();
                aPoint_textBox.Clear();

                dPoint_textBox.Enabled = true;
                ePoint_textBox.Enabled = true;
                aPoint_textBox.Enabled = true;
            }
        }
    }
}
