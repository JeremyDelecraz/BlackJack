using BlackJack.Data;
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
using System.Windows.Media;

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
                    Fill =  (SolidColorBrush)new BrushConverter().ConvertFrom("#2ecc71")
                },
                new PieSeries
                {
                    Title = "Egalité",
                    Values = new ChartValues<double> {0},
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFrom("#f1c40f")
                },
                new PieSeries
                {
                    Title = "Perdant",
                    Values = new ChartValues<double> {0},
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFrom("#e74c3c")
                },
                new PieSeries
                {
                    Title = "Assurance",
                    Values = new ChartValues<double> {0},
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFrom("#2c3e50")
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
            caChart.DisableAnimations = true;
        }

        public void setValuePie(PlayerData playerData)
        {
            pChart.Series[0].Values = new ChartValues<double> { playerData.NbWin };
            pChart.Series[1].Values = new ChartValues<double> { playerData.NbEqual };
            pChart.Series[2].Values = new ChartValues<double> { playerData.NbLose };
            pChart.Series[3].Values = new ChartValues<double> { playerData.NbInsurance };
        }

        public void addValueChart(PlayerData playerData, int nbTurn)
        {
            caChart.AxisX[0].Labels.Add(nbTurn.ToString());
            caChart.Series[0].Values.Add((Double)playerData.Cash);
        }

        public void reset()
        {
            caChart.AxisX[0].Labels.Clear();
            caChart.Series[0].Values.Clear();
            pChart.Series[0].Values = new ChartValues<double> { 0 };
            pChart.Series[1].Values = new ChartValues<double> { 0 };
            pChart.Series[2].Values = new ChartValues<double> { 0 };
            pChart.Series[3].Values = new ChartValues<double> { 0 };
        }

        public void previous()
        {
            for (int i = 0; i < 2; i++)
            {
                if (caChart.AxisX[0].Labels.Count > 0)
                {
                    caChart.AxisX[0].Labels.RemoveAt(caChart.AxisX[0].Labels.Count - 1);
                    caChart.Series[0].Values.RemoveAt(caChart.Series[0].Values.Count - 1);
                }
            }
        }

        private void FrmData_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !FrmGameClose;
        }
    }
}
