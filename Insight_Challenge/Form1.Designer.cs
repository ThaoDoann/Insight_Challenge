namespace Insight_Challenge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createChartBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.XminTB = new System.Windows.Forms.TextBox();
            this.XmaxTB = new System.Windows.Forms.TextBox();
            this.YminTB = new System.Windows.Forms.TextBox();
            this.YmaxTB = new System.Windows.Forms.TextBox();
            this.totalDemandsTB = new System.Windows.Forms.TextBox();
            this.totalSuppliersTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(261, 35);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Demand Points";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Supply Points";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(690, 421);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max X";
            // 
            // createChartBtn
            // 
            this.createChartBtn.Location = new System.Drawing.Point(26, 310);
            this.createChartBtn.Name = "createChartBtn";
            this.createChartBtn.Size = new System.Drawing.Size(75, 23);
            this.createChartBtn.TabIndex = 5;
            this.createChartBtn.Text = "Create Chart";
            this.createChartBtn.UseVisualStyleBackColor = true;
            this.createChartBtn.Click += new System.EventHandler(this.createChartBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(26, 351);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // XminTB
            // 
            this.XminTB.Location = new System.Drawing.Point(112, 35);
            this.XminTB.Name = "XminTB";
            this.XminTB.Size = new System.Drawing.Size(100, 20);
            this.XminTB.TabIndex = 7;
            // 
            // XmaxTB
            // 
            this.XmaxTB.Location = new System.Drawing.Point(112, 61);
            this.XmaxTB.Name = "XmaxTB";
            this.XmaxTB.Size = new System.Drawing.Size(100, 20);
            this.XmaxTB.TabIndex = 8;
            // 
            // YminTB
            // 
            this.YminTB.Location = new System.Drawing.Point(112, 86);
            this.YminTB.Name = "YminTB";
            this.YminTB.Size = new System.Drawing.Size(100, 20);
            this.YminTB.TabIndex = 9;
            // 
            // YmaxTB
            // 
            this.YmaxTB.Location = new System.Drawing.Point(112, 112);
            this.YmaxTB.Name = "YmaxTB";
            this.YmaxTB.Size = new System.Drawing.Size(100, 20);
            this.YmaxTB.TabIndex = 10;
            // 
            // totalDemandsTB
            // 
            this.totalDemandsTB.Location = new System.Drawing.Point(112, 206);
            this.totalDemandsTB.Name = "totalDemandsTB";
            this.totalDemandsTB.Size = new System.Drawing.Size(100, 20);
            this.totalDemandsTB.TabIndex = 11;
            // 
            // totalSuppliersTB
            // 
            this.totalSuppliersTB.Location = new System.Drawing.Point(112, 232);
            this.totalSuppliersTB.Name = "totalSuppliersTB";
            this.totalSuppliersTB.Size = new System.Drawing.Size(100, 20);
            this.totalSuppliersTB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total demands";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Suppliers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalSuppliersTB);
            this.Controls.Add(this.totalDemandsTB);
            this.Controls.Add(this.YmaxTB);
            this.Controls.Add(this.YminTB);
            this.Controls.Add(this.XmaxTB);
            this.Controls.Add(this.XminTB);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.createChartBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createChartBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox XminTB;
        private System.Windows.Forms.TextBox XmaxTB;
        private System.Windows.Forms.TextBox YminTB;
        private System.Windows.Forms.TextBox YmaxTB;
        private System.Windows.Forms.TextBox totalDemandsTB;
        private System.Windows.Forms.TextBox totalSuppliersTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

