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
    public partial class FrmGame : Form
    {
        private int nbDeck;
        private int nbPlayer;
        private int nbTurnMax;
        private int nbTurn;
        private int nbTable;
        private int cash;
        private List<Game> lstGame = new List<Game>();
        private PlayerPro playerPro;
        private int idGame = -1;

        public FrmGame()
        {
            InitializeComponent();
            //802; 326
        }

        public FrmGame(int nbDeck,int nbPlayer,int nbTurnMax,int nbTable,int cash) : base()
        {
            InitializeComponent();
            this.nbDeck = nbDeck;
            this.nbPlayer = nbPlayer;
            this.nbTurnMax = nbTurnMax;
            this.nbTable = nbTable;
            this.cash = cash;
            initTable();
            tmrTurn.Enabled = true;
        }

        private void initTable()
        {
            lstGame.Clear();
            for (int i = 0; i < nbTable; i++)
            {
                lstGame.Add(new Game(nbDeck, nbPlayer, cash));
            }
            playerPro = new PlayerPro(cash);
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            setTables();
        }

        private void setTables()
        {
            int x = 0;
            int y = 0;
            int distX = 802;
            int distY = 326;
            for (int i = 0; i < nbTable; i++)
            {
                TableUC tableUC = new TableUC();
                tableUC.Location = new Point(((i % 2 != 0) ? (x + distX) : x), y);
                tableUC.initTable(nbPlayer,i);
                if (i % 2 != 0) { y += distY; }
                Controls.Add(tableUC);
            }
        }

        private void tmrTurn_Tick(object sender, EventArgs e)
        {
            Text = nbTurn.ToString();
            if (nbTurn == nbTurnMax)
            {
                tmrTurn.Enabled = false;
                nbTurnMax = 0;
            }
            testIdGame();
            playEachGame();
            displayValue();
            nbTurn++;
        }

        private void testIdGame()
        {
            if (idGame < 0)
            {
                idGame = getGameIndMaxSabotValue();
                if (idGame >= 0)
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
            return (lstGame[id].RealSabotValue >= PlayerPro.SABOT_TO_PLAY) ? id : -1;
        }

        private void playEachGame()
        {
            for (int i = 0; i < lstGame.Count; i++)
            {
                lstGame[i].play();
            }
        }

        private void displayValue()
        {
            int id = 0;
            foreach(TableUC tableUC in Controls)
            {
                Hand handBank = lstGame[id].getBankHand();
                tableUC.setBank(handBank.getLstIndexImage(), handBank.Value);
                setPlayer(id, tableUC);
                if (id == idGame)
                {
                    List<Hand> lstHandPlPro = lstGame[idGame].getPlayerProHand();
                    List<List<int>> lstHandIndxImg = new List<List<int>>();
                    List<int> lstValue = new List<int>();
                    for (int i = 0; i < lstHandPlPro.Count; i++)
                    {
                        lstHandIndxImg.Add(lstHandPlPro[i].getLstIndexImage());
                        lstValue.Add(lstHandPlPro[i].Value);
                    }
                    tableUC.setPlayerPro(lstHandIndxImg, lstValue,playerPro.Cash);
                }
                else
                {
                    tableUC.removePlayerPro();
                }             
                id++;
            }
        }

        private void setPlayer(int idTable, TableUC tableUC)
        {
            List<PlayerLambda> lstP = lstGame[idTable].LstPlayer;
            List<List<List<int>>> lstPlayerHandIndexImage = new List<List<List<int>>>();
            List<List<int>> lstPlayerValue = new List<List<int>>();
            List<int> lstPlayerCash = new List<int>();
            for (int i = 0; i < lstP.Count; i++)
            {
                List<Hand> lstHandPlayer = lstP[i].LstHand;
                List<List<int>> lstHandIndexImg = new List<List<int>>();
                List<int> lstValue = new List<int>();
                for (int j = 0; j < lstHandPlayer.Count; j++)
                {
                    lstHandIndexImg.Add(lstHandPlayer[j].getLstIndexImage());
                    lstValue.Add(lstHandPlayer[j].Value);
                }
                lstPlayerHandIndexImage.Add(lstHandIndexImg);
                lstPlayerValue.Add(lstValue);
                lstPlayerCash.Add(lstP[i].Cash);
            }
            tableUC.setPlayers(lstPlayerHandIndexImage, lstPlayerValue, lstPlayerCash);
        }

        private void FrmGame_Click(object sender, EventArgs e)
        {
            tmrTurn.Enabled = !tmrTurn.Enabled;
        }
    }
}
