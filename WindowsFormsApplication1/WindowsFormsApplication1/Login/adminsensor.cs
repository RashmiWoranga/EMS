using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class adminsensor : Form
    {
        float[] val;
        String[] x;
        String xName;
        public adminsensor(float[] val1,String[] x1,String name)
        {
            val = val1;
            x = x1;
            xName = name;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminsensor_Load(object sender, EventArgs e)
        {
            string[] seriesArray = x;
            float[] pointsArray = val;

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add(xName);
            this.chart1.ChartAreas[0].AxisY.Interval = 1;
           // this.chart1.ChartAreas[0].AxisY.AxisName = "\'Ç";
            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);


                // Add point.
                series.Points.Add(pointsArray[i]);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
