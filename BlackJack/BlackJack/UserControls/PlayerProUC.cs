using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.UserControls
{
    public partial class PlayerProUC : UserControl
    {
        public PlayerProUC()
        {
            InitializeComponent();
        }

        public void setData(int cash,int nbWin,int nbEqual,int nbLose)
        {
            lblCashValue.Text = cash.ToString();
            lblNbWinValue.Text = nbWin.ToString();
            lblNbEqualValue.Text = nbEqual.ToString();
            lblNbLoseValue.Text = nbLose.ToString();

        }
    }
}
