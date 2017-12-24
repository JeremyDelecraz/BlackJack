using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Class;

namespace BlackJack
{
    public partial class FrmMain : Form
    {
        private const int CASH = 50000;
        private int cash = CASH;
        private int nbTurn = 0;
        private Game g;
        public FrmMain()
        {
            InitializeComponent();
            this.lblCashBaseValue.Text = CASH.ToString();
            this.lblAccountValue.Text = CASH.ToString();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            nbTurn = 0;
            cash = CASH;
            tmrTurn.Enabled = true;
            g = new Game((int)nupNbDeck.Value, (int)nupNbPlayer.Value, CASH, this);
        }

        private void tmrTurn_Tick(object sender, EventArgs e)
        {
            lblNbTurnValue.Text = nbTurn.ToString();
            if (nbTurn == (int)nupNbTurn.Value) {
                tmrTurn.Enabled = false;
                nbTurn = 0;
            }
            g.play(1);
            lblAccountValue.Text = g.getCashProPlayer().ToString();
            List<int> lstWinEqualLose = g.getWinEqualLose();
            lblNbWinValue.Text = lstWinEqualLose[0].ToString();
            lblNbEqualValue.Text = lstWinEqualLose[1].ToString();
            lblNbLoseValue.Text = lstWinEqualLose[2].ToString();
            lblSabotValue.Text = g.realSabotValue.ToString();
            nbTurn++;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            tmrTurn.Enabled = !tmrTurn.Enabled;

        }
    }
}
