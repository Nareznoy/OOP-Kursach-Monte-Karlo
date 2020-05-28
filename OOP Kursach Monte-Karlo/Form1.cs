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
            Point dPoint;
            Point ePoint;
            Point aPoint;

            string[] temp = dPoint_textBox.Text.Split(new char[] { ' ', ',' });
            dPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));

            temp = ePoint_textBox.Text.Split(new char[] { ' ', ',' });
            ePoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));

            temp = aPoint_textBox.Text.Split(new char[] { ' ', ',' });
            aPoint = new Point(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));


            BorderFigure figure = new BorderFigure(dPoint, ePoint, aPoint);

            MonteCarlo monteCarlo = new MonteCarlo(figure);

            for (uint i = 0; i < 5; i++)
            {
                dataGridView.Rows.Add("10^" + (3 + i), monteCarlo.CalculateSquare((int)Math.Pow(10, 3 + i)));
            }

            dataGridView.Rows.Add("Actual Square", figure.actualSquare());
        }
    }
}
