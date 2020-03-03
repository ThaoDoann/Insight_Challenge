using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Insight_Challenge
{
    public partial class Form1 : Form
    {   
        private List<Series> lineSeries = new List<Series>();
        public Form1()
        {
            InitializeComponent();
        }

        // Validate inputs before creating  a chart
        private bool valiDateInputs()
        {   
            return (double.TryParse(XminTB.Text, out _) && double.TryParse(XmaxTB.Text, out _)
                && double.TryParse(YminTB.Text, out _) && double.TryParse(YmaxTB.Text, out _)
                && int.TryParse(totalDemandsTB.Text, out _) && int.TryParse(totalSuppliersTB.Text, out _));
        }
        private void createChartBtn_Click(object sender, EventArgs e)
        {
            if (valiDateInputs()) {
                //Initialize Chart Area
                int minX = Int32.Parse(XminTB.Text);
                int maxX = Int32.Parse(XmaxTB.Text);
                int minY = Int32.Parse(YminTB.Text);
                int maxY = Int32.Parse(YmaxTB.Text);

                chart.ChartAreas["ChartArea1"].AxisX.Minimum = minX;
                chart.ChartAreas["ChartArea1"].AxisX.Maximum = maxX;
                chart.ChartAreas["ChartArea1"].AxisY.Minimum = minY;
                chart.ChartAreas["ChartArea1"].AxisY.Maximum = maxY;

                // Initialize and display Demand and Supply points randomly
                Random rand = new Random();
                int totalDemands = Int32.Parse(totalDemandsTB.Text);
                int totalSuppliers = Int32.Parse(totalSuppliersTB.Text);

                List<DataPoint> demandPoints = new List<DataPoint>();
                List<DataPoint> supplyPoints = new List<DataPoint>();
                for (int i = 0; i < totalDemands; i++)
                {
                    DataPoint newDemand = new DataPoint(rand.Next(minX, maxX), rand.Next(minY, maxY));
                    demandPoints.Add(newDemand);
                    chart.Series["Demand Points"].Points.Add(newDemand);
                }
                
                for (int i = 0; i < totalSuppliers; i++)
                {
                    DataPoint newSupplier = new DataPoint(rand.Next(minX, maxX), rand.Next(minY, maxY));
                    supplyPoints.Add(newSupplier);
                    chart.Series["Supply Points"].Points.Add(newSupplier);
                }
                createChartBtn.Enabled = false;

                //Calculate and draw line to describe the closest supplier of each demand
                foreach (DataPoint demand in demandPoints)
                {
                    DataPoint supplier = getClosestSupplier(demand, supplyPoints);

                    Series series = chart.Series.Add("Line " + lineSeries.Count + 1);
                    series.Points.AddXY(demand.XValue, demand.YValues[0]);
                    series.Points.AddXY(supplier.XValue, supplier.YValues[0]);
                    series.ChartType = SeriesChartType.Line;
                    series.Color = Color.Black;
                    series.IsVisibleInLegend = false;

                    lineSeries.Add(series);
                }
            } else
                MessageBox.Show("All inputs must be numeric", "ERROR!!!",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        /* Calculate the distance between a particular demand and a supplier */
        private double calDistance(DataPoint demand, DataPoint supplier)
        {
            double Xdistance = demand.XValue - supplier.XValue;
            double Ydistance = demand.YValues[0] - supplier.YValues[0];
            return Math.Sqrt(Xdistance * Xdistance + Ydistance * Ydistance);
        }

        /* Calculate distance to each supplier to find the nearest supplier*/
        private DataPoint getClosestSupplier(DataPoint demand, List<DataPoint> suppliers)
        {
            DataPoint closestSupplier = suppliers[0];
            double closestDistance = calDistance(demand, suppliers[0]);

            foreach (DataPoint supplier in suppliers)
            {
                if(calDistance(demand, supplier) < closestDistance)
                {
                    closestDistance = calDistance(demand, supplier);
                    closestSupplier = supplier;
                }
            }
            return closestSupplier;
        }
        
        // Reset the program, clear demand/supply points + remove all lines
        private void resetBtn_Click(object sender, EventArgs e)
        {
            XminTB.Text = "";
            XmaxTB.Text = "";
            YminTB.Text = "";
            YmaxTB.Text = "";
            totalDemandsTB.Text = "";
            totalSuppliersTB.Text = "";

            chart.Series["Demand Points"].Points.Clear();
            chart.Series["Supply Points"].Points.Clear();
            lineSeries.ForEach(line => { chart.Series.Remove(line); });

            lineSeries.Clear();

            createChartBtn.Enabled = true;
        }
    }
}
