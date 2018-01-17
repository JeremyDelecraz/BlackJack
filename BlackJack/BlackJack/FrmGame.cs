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
            frmData = frm;
            StartPosition = FormStartPosition.Manual;

            Location = new Point(0, 0);
            frmData.Show();
            initDisplayTable(nbTable, nbPlayer);
            tmrTurn.Enabled = true;
            frmData.StartPosition = FormStartPosition.Manual;
            frmData.Location = new Point( 0, Size.Height -50);
        }

        private void initDisplayTable(int nbTable,int nbPlayer)
        {
            int x = 0;
            int y = 80;
            int distX = 500;
            int distY = 370;
            int width = Screen.PrimaryScreen.Bounds.Size.Width / distY ;
            Size = new Size((width - 1) * distY + 50, Screen.PrimaryScreen.Bounds.Size.Height - frmData.Size.Height);

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
            foreach (Table table in lstTable)
            {
                tableData = new TableData(table);
                if (table.PlayerPro != null) { tableData.setPlayerPro(table.PlayerPro); }
                turnData.addTableData(tableData);
            }
            turnData.setPlayerPro(playerPro);
            gameData.addTurnData(turnData);
        }

        /// <summary>
        /// Le timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            bool playerProPlaying = false;
            foreach (TableUC tableUC in Controls.OfType<TableUC>())
            {
                double previousSabotValue = 0;
                if (nbTurn > 0) { previousSabotValue = gameData.LstTurnData[nbTurn].LstTable[id].SabotValue; }
                TableData tableData = gameData.LstTurnData[nbTurn].LstTable[id++];
                tableUC.setBank(tableData.HandBank);
                tableUC.setPlayers(tableData);
                playerProPlaying = (setPlayerPro(tableData, tableUC, previousSabotValue) || playerProPlaying);
                tableUC.setSabotValue(tableData.SabotValue);
                tableUC.setNbCard(tableData.NbCard);
            }
            displayPlayerProOutTable(playerProPlaying);

            lblNbTurnValue.Text = (nbTurn+ 1).ToString();
            setEnabledButton();
        }

        /// <summary>
        /// Affichage du joueur pro au coin s'il n'est pas sur une table
        /// </summary>
        /// <param name="isPlaying"></param>
        private void displayPlayerProOutTable(bool isPlaying)
        {
            if (!isPlaying)
            {
                PlayerData playerData = gameData.LstTurnData[nbTurn].PlayerPro;
                playerProUC.setData(playerData);
                frmData.setValue(playerData,nbTurn + 1);
                playerProUC.Visible = true;
            }
            else
            {
                playerProUC.Visible = false;
            }
        }

        /// <summary>
        /// Gestion des boutons
        /// </summary>
        private void setEnabledButton()
        {
            btnNext.Enabled = (nbTurn < nbTurnMax - 1) && !tmrTurn.Enabled;
            btnPrevious.Enabled = (nbTurn > 0) && !tmrTurn.Enabled;
            btnFirst.Enabled = (nbTurn > 0) && !tmrTurn.Enabled;
            btnLast.Enabled = (nbTurn < nbTurnMax - 1) && !tmrTurn.Enabled;
            if (nbTurn == nbTurnMax - 1)
            {
                btnPausePlay.Image = Properties.Resources.Restart;
                btnPausePlay.Tag = VALUE_TAG_RESTART;
            }
            else
            {
                btnPausePlay.Image = (tmrTurn.Enabled) ? Properties.Resources.Pause : Properties.Resources.Play;
            }
        }

        /// <summary>
        /// Ajoute le joueurs pro dans une table (Graphiquement) que s'il est
        /// </summary>
        /// <param name="tableData"></param>
        /// <param name="tableUC"></param>
        /// <param name="previousSabot"></param>
        /// <returns>Si le joueur pro est existant</returns>
        private bool setPlayerPro(TableData tableData, TableUC tableUC,double previousSabot)
        {
            if (tableData.PlayerPro != null)
            {
                tableUC.setPlayerPro(tableData.PlayerPro);
                frmData.setValue(tableData.PlayerPro,nbTurn + 1);
                return true;
            }
            else
            {
                tableUC.removePlayerPro();
                return false;
            }
        }

#region GestionBoutons
        private void btnFirst_Click(object sender, EventArgs e)
        {
            nbTurn = 0;
            frmData.reset();
            displayValue();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            nbTurn--;
            frmData.previous();
            displayValue();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nbTurn++;
            displayValue();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            for (int i = nbTurn; i < nbTurnMax - 2; i++)
            {
                frmData.setValue(gameData.LstTurnData[i].PlayerPro, i + 1);
            }
            nbTurn = nbTurnMax -1;
            displayValue();
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (btnPausePlay.Tag !=null && btnPausePlay.Tag.Equals(VALUE_TAG_RESTART)) {
                btnPausePlay.Image = Properties.Resources.Pause;
                nbTurn = 0;
                frmData.reset();
                displayValue();
                tmrTurn.Enabled = true;
                btnPausePlay.Tag = null;
            }
            else
            {
                tmrTurn.Enabled = !tmrTurn.Enabled;
                btnPausePlay.Image = (tmrTurn.Enabled) ? Properties.Resources.Pause : Properties.Resources.Play;
            }
            setEnabledButton();
            //btnLast.Enabled = !tmrTurn.Enabled;
            //btnFirst.Enabled = !tmrTurn.Enabled;
            //btnPrevious.Enabled = !tmrTurn.Enabled;
            //btnNext.Enabled = !tmrTurn.Enabled;
        }
        #endregion

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmData.FrmGameClose = true;
            frmData.Close();
        }
    }
}
