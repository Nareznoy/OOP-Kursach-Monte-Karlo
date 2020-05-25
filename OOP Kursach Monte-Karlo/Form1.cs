using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kursach_Monte_Karlo
{
    public partial class Form1 : Form
    {
        private Point _dPoint;
        private Point _ePoint;
        private Point _aPoint;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] temp = dPoint_textBox.Text.Split(new char[] { ' ', ',' });
            _dPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));

            temp = ePoint_textBox.Text.Split(new char[] { ' ', ',' });
            _ePoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));

            temp = aPoint_textBox.Text.Split(new char[] { ' ', ',' });
            _aPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));

            calculateUsingOOP();
            calcualteUsingProcedural();
        }


        private void calculateUsingOOP()
        {
            BorderFigure figure = new BorderFigure(_dPoint, _ePoint, _aPoint);

            int insidePointCounter;
            double randomX;
            double randomY;
            for (uint i = 0; i < 5; i++)
            {
                insidePointCounter = 0;
                for (uint j = 0; j < Math.Pow(10, 3 + i); j++)
                {
                    randomX = figure.MinX + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (figure.MaxX - figure.MinX);
                    randomY = figure.MinY + Convert.ToDouble(random.Next(0, 32767)) / 32767 * (figure.MaxY - figure.MinY);

                    if (figure.isInside(new Point(randomX, randomY)) == true)
                    {
                        insidePointCounter++;
                    }

                }
                dataGridView.Rows.Add("10^" + (3 + i), figure.RectangleSquare * insidePointCounter / Math.Pow(10, 3 + i));
            }

            dataGridView.Rows.Add("Actual Square", figure.actualSquare());
        }

        private void calcualteUsingProcedural()
        {
            Procedural temp = new Procedural();
            List<double> squares = temp.calculate(_dPoint, _ePoint, _aPoint);

            for (int i = 0; i < squares.Count; i++)
            {
                dataGridView1.Rows.Add("10^" + (3 + i), squares[i]);
            }

            dataGridView1.Rows.Add("Actual Square", temp.actualSquare());
        }
    }
}
