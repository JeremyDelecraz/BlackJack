using BlackJack.Class;
using BlackJack.Data;
using BlackJack.UserControls;
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
    public partial class FrmGame : Form
    {
        private int idGame;
        private int nbTurn;
        private int nbTurnMax;
        private List<Table> lstTable = new List<Table>();
        private PlayerPro playerPro;
        private GameData gameData = new GameData();
        private const string VALUE_TAG_RESTART = "Restart";
        private FrmData frmData;

        public FrmGame(int nbDeck, int nbPlayer, int nbTurn, int nbTable, int cash,FrmData frm)
        {
            InitializeComponent();
            nbTurnMax = nbTurn;
            for (int i = 0; i < nbTable; i++)
            {
                lstTable.Add(new Table(nbDeck, nbPlayer, cash));
            }
            playerPro = new PlayerPro(cash);
            play();
            initDisplayTable(nbTable, nbPlayer);
            tmrTurn.Enabled = true;
            frmData = frm;
            frmData.Show();
        }

        private void initDisplayTable(int nbTable,int nbPlayer)
        {
            Size = Screen.PrimaryScreen.Bounds.Size;
            int x = 0;
            int y = 80;
            int distX = 500;
            int distY = 370;
            for (int i = 0; i < nbTable; i++)
            {
                TableUC tableUC = new TableUC();
                tableUC.initTable(nbPlayer, i + 1);
                tableUC.Location = new Point(x, y);
                Controls.Add(tableUC);
                x += distX;
                if(x + tableUC.Size.Width > Size.Width)
                {
                    x = 0;
                    y += distY;
                }
            }
        }

        private void play()
        {
            for (int i = 0; i < nbTurnMax; i++)
            {
                testIdGame();
                playEachGame();
                saveData();
            }
        }

        /// <summary>
        /// Sauvegarde des données avant le l'affichage
        /// </summary>
        private void saveData()
        {
            TableData tableData;
            TurnData turnData = new TurnData();
            int nbTable = 0;
            foreach (Table table in lstTable)
            {
                if(table.PlayerPro == null) {
                    tableData = new TableData(table.getBankHand(), table.RealSabotValue,table.getNbCardInDeck(), table.LstPlayer);
                    nbTable++;
                }
                else
                {
                    tableData = new TableData(table.getBankHand(), table.RealSabotValue, table.getNbCardInDeck(), table.LstPlayer, table.PlayerPro);
                }
                turnData.addTableData(tableData);
            }
            if(lstTable.Count == nbTable) { turnData.setPlayerPro(playerPro); }
            gameData.addTurnData(turnData);
        }

        private void tmrTurn_Tick(object sender, EventArgs e)
        {
            if (nbTurn >= nbTurnMax) { tmrTurn.Enabled = false; }
            else
            {
                displayValue();
                nbTurn++;
            }
        }

        /// <summary>
        /// Tester si le joueur pro est sur une table
        /// </summary>
        private void testIdGame()
        {
            if (idGame < 0)
            {
                idGame = getGameIndMaxSabotValue();
                if (idGame >= 0)
                {
                    lstTable[idGame].addPlayerPro(playerPro);
                }
            }
            else if (lstTable[idGame].RealSabotValue < PlayerPro.SABOT_TO_STAY)
            {
                PlayerPro pTest = lstTable[idGame].removeAndGetPlayerPro();
                idGame = getGameIndMaxSabotValue();
                if (idGame >= 0)
                {
                    lstTable[idGame].addPlayerPro(playerPro);
                }
            }
        }

        /// <summary>
        /// Récupération de la table avec le plus haut sabot
        /// </summary>
        /// <returns></returns>
        private int getGameIndMaxSabotValue()
        {
            int id = 0;
            double maxSabotValue = double.MinValue;
            for (int i = 0; i < lstTable.Count; i++)
            {
                if (lstTable[i].RealSabotValue > maxSabotValue)
                {
                    id = i;
                    maxSabotValue = lstTable[i].RealSabotValue;
                }
            }
            return (lstTable[id].RealSabotValue >= PlayerPro.SABOT_TO_PLAY) ? id : -1;
        }

        /// <summary>
        /// Jouer sur chaque table
        /// </summary>
        private void playEachGame()
        {
            foreach (Table table in lstTable)
            {
                table.play();
            }
        }

        /// <summary>
        /// Affichage des valeurs dans les UserControls
        /// </summary>
        private void displayValue()
        {
            int id = 0;
            foreach (TableUC tableUC in Controls.OfType<TableUC>())
            {
                TableData tableData = gameData.LstTurnData[nbTurn].LstTable[id++];
                Hand handBank = tableData.HandBank;
                tableUC.setBank(handBank.Value, handBank.getNbCard());
                setPlayers(tableData, tableUC);
                setPlayerPro(tableData, tableUC);
                tableUC.setSabotValue(tableData.SabotValue);
                tableUC.setNbCard(tableData.NbCard);
            }
            if (gameData.LstTurnData[nbTurn].PlayerPro != null)
            {
                PlayerData playerData = gameData.LstTurnData[nbTurn].PlayerPro;
                PlayerData playerPro = gameData.LstTurnData[nbTurn].PlayerPro;
                playerProUC.setData(playerData.Cash, playerData.NbWin, playerData.NbEqual, playerData.NbLose);
                frmData.setValue(playerPro.NbWin, playerPro.NbEqual, playerPro.NbLose,nbTurn,playerPro.Cash);
                playerProUC.Visible = true;
            }
            else {
                playerProUC.Visible = false;
            }

            lblNbTurnValue.Text = (nbTurn+ 1).ToString();
            btnNext.Enabled = (nbTurn < nbTurnMax -1) && !tmrTurn.Enabled;
            btnPrevious.Enabled = (nbTurn > 0) && !tmrTurn.Enabled;
            btnFirst.Enabled = (nbTurn > 0) && !tmrTurn.Enabled;
            btnLast.Enabled = (nbTurn < nbTurnMax-1) && !tmrTurn.Enabled;
            if (nbTurn == nbTurnMax - 1)
            {
                btnPausePlay.Image = BlackJack.Properties.Resources.Restart;
                btnPausePlay.Tag = VALUE_TAG_RESTART;
            }
               
        }

        private void setPlayers(TableData tableData, TableUC tableUC)
        {
            List<PlayerData> lstP = tableData.LstPlayer;
            List<List<int>> lstPlayerValue = new List<List<int>>();
            List<List<int>> lstPlayerNbCard = new List<List<int>>();
            List<int> lstPlayerCash = new List<int>();
            for (int i = 0; i < lstP.Count; i++)
            {
                List<HandData> lstHandPlayer = lstP[i].LstHand;
                List<int> lstValue = new List<int>();
                List<int> lstNbCard = new List<int>();
                for (int j = 0; j < lstHandPlayer.Count; j++)
                {
                    lstValue.Add(lstHandPlayer[j].Value);
                    lstNbCard.Add(lstHandPlayer[j].Nbcard);
                }
                lstPlayerValue.Add(lstValue);
                lstPlayerNbCard.Add(lstNbCard);
                lstPlayerCash.Add(lstP[i].Cash);
            }
            tableUC.setPlayers(lstPlayerValue, lstPlayerNbCard, lstPlayerCash);
        }

        private void setPlayerPro(TableData tableData, TableUC tableUC)
        {
            if (tableData.PlayerPro != null)
            {
                List<HandData> lstHandPlPro = tableData.PlayerPro.LstHand;
                List<List<int>> lstHandIndxImg = new List<List<int>>();
                List<int> lstValue = new List<int>();
                List<int> lstNbCard = new List<int>();
                for (int i = 0; i < lstHandPlPro.Count; i++)
                {
                    lstValue.Add(lstHandPlPro[i].Value);
                    lstNbCard.Add(lstHandPlPro[i].Nbcard);
                }
                tableUC.setPlayerPro(lstValue, lstNbCard, tableData.PlayerPro.Cash);
                frmData.setValue(tableData.PlayerPro.NbWin, tableData.PlayerPro.NbEqual, tableData.PlayerPro.NbLose,nbTurn, tableData.PlayerPro.Cash);
            }
            else
            {
                tableUC.removePlayerPro();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            nbTurn = 0;
            displayValue();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            nbTurn--;
            displayValue();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nbTurn++;
            displayValue();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            nbTurn = nbTurnMax -1;
            displayValue();
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (btnPausePlay.Tag !=null && btnPausePlay.Tag.Equals(VALUE_TAG_RESTART)) {
                btnPausePlay.Image = Properties.Resources.Pause;
                nbTurn = 0;
                displayValue();
                tmrTurn.Enabled = true;
                btnPausePlay.Tag = null;
            }
            else
            {
                tmrTurn.Enabled = !tmrTurn.Enabled;
                btnPausePlay.Image = (tmrTurn.Enabled) ? BlackJack.Properties.Resources.Pause : BlackJack.Properties.Resources.Play;
            }
            btnLast.Enabled = !tmrTurn.Enabled;
            btnFirst.Enabled = !tmrTurn.Enabled;
            btnPrevious.Enabled = !tmrTurn.Enabled;
            btnNext.Enabled = !tmrTurn.Enabled;
        }
    }
}
