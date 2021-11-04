using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_of_Best_Fit_Project
{
    public partial class Form1 : Form
    {
        public static List<(decimal, decimal)> dataPoints;
        public static decimal M;
        public static decimal B;
        Bitmap canvas;
        Graphics gfx;
        int originX;
        int originY;

        public Form1()
        {
            InitializeComponent();
            dataPoints = new List<(decimal, decimal)>();
            M = 0;
            B = 0;
            canvas = new Bitmap(canvasPictureBox.Width, canvasPictureBox.Height);
            originX = canvasPictureBox.Width / 2;
            originY = canvasPictureBox.Width / 2;
            gfx = Graphics.FromImage(canvas);
            Graph();
            xValue.Minimum = -originX + 5;
            xValue.Maximum = originX - 5;
            yValue.Minimum = -originY + 5;
            yValue.Maximum = originY - 5;
        }

        public static decimal LinearEquationSolver(decimal x)
        {
            return (x * M) + B;
        }

        public static void Mutation()
        {
            Random rand = new Random();
            int variable = rand.Next(2);
            if (variable == 0)
            {
                int increment = rand.Next(2);
                if (increment == 0)
                {
                    M += 0.1m;
                }
                else
                {
                    M -= 0.1m;
                }
            }
            else
            {
                int increment = rand.Next(2);
                if (increment == 0)
                {
                    B += 0.1m;
                }
                else
                {
                    B -= 0.1m;
                }
            }
        }

        public static decimal MeanAbsoluteError()
        {
            decimal summation = 0;
            foreach (var point in dataPoints)
            {
                summation += Math.Abs(LinearEquationSolver(point.Item1) - point.Item2);
            }
            return summation / dataPoints.Count();
        }

        public static decimal MeanSquaredError()
        {
            decimal summation = 0;
            foreach (var point in dataPoints)
            {
                summation += (decimal)Math.Pow((double)(LinearEquationSolver(point.Item1) - point.Item2), 2);
            }
            return summation / dataPoints.Count();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dataPoints.Add((xValue.Value, yValue.Value));
            Graph();
        }

        private void LinearRegression_Click(object sender, EventArgs e)
        {

            var originalError = MeanAbsoluteError();
            while (originalError > 0.1m)
            {
                var originalM = M;
                var originalB = B;

                Mutation();

                var newError = MeanAbsoluteError();

                if (newError < originalError)
                {
                    originalError = newError;
                }
                else
                {
                    M = originalM;
                    B = originalB;
                }
            }

            DrawLine();
        }

        private void RandomAdd_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            decimal x = rand.Next(-originX + 5, originX - 5);
            decimal y = rand.Next(-originY + 5, originY - 5);
            xValue.Value = x;
            yValue.Value = y;
            dataPoints.Add((x, y));

            Graph();
        }

        public void Graph()
        {
            gfx.Clear(Color.White);
            gfx.DrawLine(new Pen(Color.Black), new Point(0, originY), new Point(canvasPictureBox.Width, originY));
            gfx.DrawLine(new Pen(Color.Black), new Point(originX, 0), new Point(originX, canvasPictureBox.Height));

            foreach (var point in dataPoints)
            {
                gfx.FillEllipse(Brushes.Black, (float)point.Item1 + originX - 5, -(float)point.Item2 + originY - 5, 10, 10);
            }

            canvasPictureBox.Image = canvas;
        }

        public void DrawLine()
        {
            gfx.DrawLine(new Pen(Color.Red), new Point(-originX, (int)LinearEquationSolver(-originX)), new Point(originX, (int)LinearEquationSolver(originX)));
        }
    }
}
