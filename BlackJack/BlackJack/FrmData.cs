using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FrmData : Form
    {
        public bool FrmGameClose { get; set; } = false;
        public FrmData()
        {
            InitializeComponent();
            initPie();
            initCartesian();
        }

        private void initPie()
        {
            pChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Gagnant",
                    Values = new ChartValues<double> {0},
                },
                new PieSeries
                {
                    Title = "Egalité",
                    Values = new ChartValues<double> {0},
                },
                new PieSeries
                {
                    Title = "Perdant",
                    Values = new ChartValues<double> {0},
                },
            };

            pChart.LegendLocation = LegendLocation.Bottom;
            pChart.DisableAnimations = true;
        }

        private void initCartesian()
        {
            caChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "ARGENT",
                    Values = new ChartValues<double> {}
                }
            };

            caChart.AxisX.Add(new Axis
            {
                Title = "Tour",
                Labels = new List<String>()
            });

            caChart.AxisY.Add(new Axis
            {
                Title = "Argent",
            });
        }

        public void setValueChart(int nbWin,int nbEqual,int nbLose,int nbTurn,int cash)
        {
            pChart.Series[0].Values = new ChartValues<double> { nbWin };
            pChart.Series[1].Values = new ChartValues<double> { nbEqual };
            pChart.Series[2].Values = new ChartValues<double> { nbLose };
            caChart.AxisX[0].Labels.Add(nbTurn.ToString());
            caChart.Series[0].Values.Add((Double)cash);
        }

        public void reset()
        {
            caChart.AxisX[0].Labels.Clear();
            caChart.Series[0].Values.Clear();
            pChart.Series[0].Values = new ChartValues<double> { 0 };
            pChart.Series[1].Values = new ChartValues<double> { 0 };
            pChart.Series[2].Values = new ChartValues<double> { 0 };
        }

        public void previous()
        {
            for (int i = 0; i < 2; i++)
            {
                if (caChart.AxisX[0].Labels.Count > 0)
                {
                    caChart.AxisX[0].Labels.RemoveAt(caChart.AxisX[0].Labels.Count - 1);
                    caChart.Series[0].Values.RemoveAt(caChart.AxisX[0].Labels.Count - 1);
                }
            }
        }

        private void FrmData_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !FrmGameClose;
        }
    }
}
