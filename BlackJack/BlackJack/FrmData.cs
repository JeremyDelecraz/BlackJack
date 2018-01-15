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
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "ARGENT",
                    Values = new ChartValues<double> {}
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tour",
                Labels = new List<String>()
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Argent",
            });
        }

        public void setValue(int nbWin,int nbEqual,int nbLose,int nbTurn,int cash)
        {
            pChart.Series[0].Values = new ChartValues<double> { nbWin };
            pChart.Series[1].Values = new ChartValues<double> { nbEqual };
            pChart.Series[2].Values = new ChartValues<double> { nbLose };
            cartesianChart1.AxisX[0].Labels.Add(nbTurn.ToString());
            cartesianChart1.Series[0].Values.Add((Double)cash);
        }
    }
}
