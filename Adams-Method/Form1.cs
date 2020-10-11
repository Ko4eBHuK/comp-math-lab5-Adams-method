using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Adams_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialAbscissaTexBox.Text = "1";
            finalAbscissaTexBox.Text = "2";
            initialOrdinateTextBox.Text = "1";
            accuracyTexBox.Text = "0,1";
            equationsList.SelectedIndex = 0;
            plotPlace.Series.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double initialAbscissa, finalAbscissa, initialOrdinate, accuracy;
            int equationIndex;

            try
            {
                initialAbscissa = Double.Parse(initialAbscissaTexBox.Text.Replace(".", ","));
                finalAbscissa = Double.Parse(finalAbscissaTexBox.Text.Replace(".", ","));
                initialOrdinate = Double.Parse(initialOrdinateTextBox.Text.Replace(".", ","));
                accuracy = Double.Parse(accuracyTexBox.Text.Replace(".", ","));
            }
            catch
            {
                MessageBox.Show("All inputs must be a real numbers");
                initialAbscissaTexBox.Text = "";
                finalAbscissaTexBox.Text = "";
                initialOrdinateTextBox.Text = "";
                accuracyTexBox.Text = "";
                return;
            }

            if(finalAbscissa < initialAbscissa)
            {
                finalAbscissa = Double.Parse(initialAbscissaTexBox.Text.Replace(".", ","));
                initialAbscissa = Double.Parse(finalAbscissaTexBox.Text.Replace(".", ","));
            }

            equationIndex = equationsList.SelectedIndex;
            var solution = new AdamsMethod(initialAbscissa, initialOrdinate, finalAbscissa, accuracy, equationIndex);

            plotPlace.Series.Clear();

            //отобажение осей координат
            double minX = initialAbscissa - (finalAbscissa - initialAbscissa) / 10;
            double maxX = finalAbscissa + (finalAbscissa - initialAbscissa) / 10;
            double minY = solution.Nodes[1, 0], maxY = solution.Nodes[1, 0];
            for(int i = 1; i < solution.Nodes.Length / 2; i++)
            {
                if (solution.Nodes[1, i] < minY) minY = solution.Nodes[1, i];
                if (solution.Nodes[1, i] > maxY) maxY = solution.Nodes[1, i];
            }
            minY = minY - (maxY - minY) / 10;
            maxY = maxY + (maxY - minY) / 10;

            plotPlace.ChartAreas[0].AxisX.Minimum = minX;
            plotPlace.ChartAreas[0].AxisX.Maximum = maxX;
            plotPlace.ChartAreas[0].AxisY.Minimum = minY;
            plotPlace.ChartAreas[0].AxisY.Maximum = maxY;

            plotPlace.ChartAreas[0].AxisX.MajorGrid.Interval = Math.Abs(maxX - minX) / 10;
            plotPlace.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            plotPlace.ChartAreas[0].AxisY.MajorGrid.Interval = Math.Abs(maxY - minY) / 10;
            plotPlace.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            Series abscissaAxis = new Series();
            abscissaAxis.LegendText = "X and";
            abscissaAxis.ChartType = SeriesChartType.Line;
            abscissaAxis.Points.AddXY(minX, 0);
            abscissaAxis.Points.AddXY(maxX, 0);
            abscissaAxis.Color = Color.Blue;
            abscissaAxis.BorderWidth = 1;
            plotPlace.Series.Add(abscissaAxis);

            Series ordinateAxis = new Series();
            ordinateAxis.LegendText = "Y axis";
            ordinateAxis.ChartType = SeriesChartType.Line;
            ordinateAxis.Points.AddXY(0, minY);
            ordinateAxis.Points.AddXY(0, maxY);
            ordinateAxis.Color = Color.Blue;
            ordinateAxis.BorderWidth = 1;
            plotPlace.Series.Add(ordinateAxis);

            //возможность приблизить область
            plotPlace.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            plotPlace.ChartAreas[0].CursorX.AutoScroll = true;
            plotPlace.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            plotPlace.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            plotPlace.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            plotPlace.ChartAreas[0].CursorY.AutoScroll = true;
            plotPlace.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            plotPlace.ChartAreas[0].AxisY.ScaleView.ZoomReset();

            //построение графика
            Series plot = new Series();
            plot.LegendText = "y(x)";
            plot.ChartType = SeriesChartType.Line;
            plot.BorderWidth = 2;
            plot.Color = Color.OrangeRed;
            for(int i = 0; i < solution.Nodes.Length / 2; i++)
            {
                plot.Points.AddXY(solution.Nodes[0, i], solution.Nodes[1, i]);
            }
            plotPlace.Series.Add(plot);

            //нанесение узлов на график
            Series nodes = new Series();
            nodes.LegendText = "Nodes";
            nodes.ChartType = SeriesChartType.Point;
            nodes.Color = Color.DarkViolet;
            for (int i = 0; i < solution.Nodes.Length / 2; i++)
            {
                    nodes.Points.AddXY(solution.Nodes[0, i], solution.Nodes[1, i]);
            }
            plotPlace.Series.Add(nodes);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            initialAbscissaTexBox.Text = "1";
            finalAbscissaTexBox.Text = "2";
            initialOrdinateTextBox.Text = "1";
            accuracyTexBox.Text = "0,1";
            equationsList.SelectedIndex = 0;
            plotPlace.Series.Clear();
        }
    }
}
