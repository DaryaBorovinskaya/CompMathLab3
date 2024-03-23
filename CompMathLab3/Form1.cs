using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompMathLab3
{
    public partial class Form1 : Form
    {
        private double[,] _numbers = new double[,] { { 2, 4, 5 ,6,7}, { 6,6,1,-1,11 } };
        private Lagrange _lagrange = new Lagrange();
        private NewtonForm _newtonForm = new NewtonForm();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();

            double x = -1, y;
            while (x < 10)
            {
                y = _lagrange.Interpolate(_numbers, x);
                chart1.Series[1].Points.AddXY(x, y);
                x += 0.25; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[2].Points.Clear();

            double[] _numbersX = new double[5];
            double[] _numbersY = new double[5];

            for (int i = 0; i < 5; i++)
                _numbersX[i] = _numbers[0, i];

            for (int i = 0; i < 5; i++)
                _numbersY[i] = _numbers[1, i];

            double x = -1, y;
            while (x < 10)
            {
                y = _newtonForm.MainFunction(x, _numbersX, _numbersY);
                chart1.Series[2].Points.AddXY(x, y);
                x+=0.25;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < chart1.Series.Count;i++)
                chart1.Series[i].Points.Clear();
        }
    }
}
