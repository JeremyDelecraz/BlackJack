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
using BlackJack.UserControls;

namespace BlackJack
{
    public partial class FrmMain : Form
    {
        private const int CASH = 100000;
        private int nbTurn = 0;
        private List<Game> lstGame = new List<Game>();
        private PlayerPro playerPro;
        private int idGame = -1;

        public FrmMain()
        {
            InitializeComponent();
            this.lblCashBaseValue.Text = CASH.ToString();
            this.lblAccountValue.Text = CASH.ToString();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
                        nbTurn = 0;
            lstGame.Clear();
            for (int i = 0; i < nupNbTable.Value; i++)
            {
                lstGame.Add(new Game((int)nupNbDeck.Value, (int)nupNbPlayer.Value, CASH));
            }
            playerPro = new PlayerPro(CASH);
            if (cbxTimer.Checked)
            {
                FrmGame frmGame = new FrmGame((int)nupNbDeck.Value, (int)nupNbPlayer.Value, (int)nupNbTurn.Value, (int)nupNbTable.Value,CASH);
                frmGame.Show();
            }
            else
                playWithoutTimer();
        }

        private void playWithoutTimer()
        {
            for (int i = 0; i < (int)nupNbTurn.Value; i++)
            {
                testIdGame();
                playEachGame();
                nbTurn++;
            }
            displayValue();
            lblNbTurnValue.Text = nbTurn.ToString();
        }

        private int getGameIndMaxSabotValue()
        {
            int id = 0;
            double maxSabotValue = double.MinValue;
            for (int i = 0; i < lstGame.Count; i++)
            {
                if (lstGame[i].RealSabotValue > maxSabotValue)
                {
                    id = i;
                    maxSabotValue = lstGame[i].RealSabotValue;
                }
            }
            return (lstGame[id].RealSabotValue >= PlayerPro.SABOT_TO_PLAY) ? id: -1;
        }

        private void playEachGame()
        {
            for (int i = 0; i < lstGame.Count; i++)
            {
                lstGame[i].play();
            }
        }

        private void testIdGame()
        {
            if (idGame < 0)
            {
                idGame = getGameIndMaxSabotValue();
                if(idGame >= 0)
                {
                    lstGame[idGame].addPlayerPro(playerPro);
                }
            }
            else if (lstGame[idGame].RealSabotValue < PlayerPro.SABOT_TO_STAY)
            {
                PlayerPro pTest = lstGame[idGame].removeAndGetPlayerPro();
                idGame = getGameIndMaxSabotValue();
                if (idGame >= 0)
                {
                    lstGame[idGame].addPlayerPro(playerPro);
                }
            }
        }

        private void displayValue()
        {
            lblAccountValue.Text = playerPro.Cash.ToString();
            lblNbWinValue.Text = playerPro.NbWin.ToString();
            lblNbEqualValue.Text = playerPro.NbEqual.ToString();
            lblNbLoseValue.Text = playerPro.NbLose.ToString();
            lblSabotValue.Text = (idGame >= 0) ? lstGame[idGame].RealSabotValue.ToString() : "0";
            lblGameIndexValue.Text = idGame.ToString();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            tmrTurn.Enabled = !tmrTurn.Enabled;
        }
    }
}
