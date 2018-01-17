using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Data;

namespace BlackJack.UserControls
{
    public partial class PlayerProUC : UserControl
    {
        public PlayerProUC()
        {
            InitializeComponent();
        }

        public void setData(PlayerData playerPro)
        {
            lblCashValue.Text = playerPro.Cash.ToString();
            lblNbWinValue.Text = playerPro.NbWin.ToString();
            lblNbEqualValue.Text = playerPro.NbEqual.ToString();
            lblNbLoseValue.Text = playerPro.NbLose.ToString();

        }
    }
}
