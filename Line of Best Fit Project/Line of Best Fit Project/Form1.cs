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

        public Form1()
        {
            InitializeComponent();
            dataPoints = new List<(decimal, decimal)>();
            M = 0;
            B = 0;
        }

        public static decimal LinearEquationSolver(decimal x)
        {
            return (x * M) + B;
        }

        public static void Mutation()
        {
            Random rand = new Random();
            int variable = rand.Next(2);
            if(variable == 0)
            {
                int increment = rand.Next(2);
                if(increment == 0)
                {
                    M+=0.1m; 
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

        private void Add_Click(object sender, EventArgs e)
        {
            dataPoints.Add((xValue.Value, yValue.Value));

        }

        private void LinearRegression_Click(object sender, EventArgs e)
        {
            //Add the linear regression stuff.
        }


        //Add the graph functionality
    }
}
