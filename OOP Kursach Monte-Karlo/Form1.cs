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

            for (uint i = 0; i < 5; i++)
            {
                dataGridView.Rows.Add("10^" + (3 + i), monteCarlo.CalculateSquare((int)Math.Pow(10, 3 + i)));
            }

            dataGridView.Rows.Add("Actual Square", figure.actualSquare());
        }


        private bool initializePoints(out Point dPoint, out Point ePoint, out Point aPoint)
        {
            bool ifValidValues = true;
            string[] temp;


            try
            {
                temp = dPoint_textBox.Text.Split(new char[] { ' ', ',' });
                dPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));
            }
            catch
            {
                dPoint = null;
                MessageBox.Show("Incorrect point d");
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
                MessageBox.Show("Incorrect point e");
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
                MessageBox.Show("Incorrect point a");
                ifValidValues = false;
            }

            return ifValidValues;
        }
    }
}
