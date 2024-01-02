using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GymOtomasyon.Models;

namespace GymOtomasyon
{
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
            DrawChart();
        }

        private void DrawChart()
        {
            int userId = 5;

            // Verileri DBLogs sınıfından al
            Dictionary<string, int> monthlyLogCounts = DBLogs.AnalyzeUserLogs(userId);

            // Grafiği çiz
            Chart chart = new Chart();
            chart.Size = panel1.Size;
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series("MonthlyLogCount"));

            // Verileri grafiğe ekle
            foreach (dynamic pair in monthlyLogCounts)
            {
                chart.Series["MonthlyLogCount"].Points.AddXY(pair.Key, pair.Value);
            }

            // Grafiği özelleştir
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "Ay";
            chart.ChartAreas[0].AxisY.Title = "Toplam Log Sayısı";
            chart.Series["MonthlyLogCount"].ChartType = SeriesChartType.Column;

            

            // Grafiği panele ekle
            panel1.Controls.Add(chart);
        }

        

    }
}
