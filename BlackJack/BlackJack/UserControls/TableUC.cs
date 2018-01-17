using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Class;
using BlackJack.Data;

namespace BlackJack.UserControls
{
    public partial class TableUC : UserControl
    {
        PlayerUC playerPro = null;
        public TableUC()
        {
            InitializeComponent();
        }

        public void initTable(int nbPlayer, int tableNumber)
        {
            int x = 5;
            int y = 12;
            int distX = 243;
            int distY = 73;
            lblNbTableValue.Text = tableNumber.ToString();
            for (int i = 0; i < nbPlayer; i++)
            {
                PlayerUC playerUC = new PlayerUC();
                playerUC.Location = new Point(((i%2 != 0) ? (x + distX) : x), y);
                if (i % 2 != 0) {y += distY;}
                gbxPlayer.Controls.Add(playerUC);
            }
        }

        public void setPlayers(TableData table)
        {
            int id = 0;
            foreach (PlayerUC playerUC in gbxPlayer.Controls)
            {
                ((PlayerUC)playerUC).setPlayer(table.LstPlayer[id],1, "Player " + id++);
            }
            Point p = new Point(5, 12); // Bank
        }

        public void setPlayerPro(PlayerData playerData)
        {
            if (playerPro == null)
            {
                playerPro = new PlayerUC();
                playerPro.Location = new Point(5, 12);
                gbxPlayerPro.Controls.Add(playerPro);
            }
            playerPro.setPlayer(playerData, 0,"Player Pro");
        }

        public void setSabotValue(double sabotValue)
        {
            lblSabotValue.BackColor = (sabotValue > PlayerPro.SABOT_TO_PLAY) ? Color.Green : (sabotValue > PlayerPro.SABOT_TO_STAY) ? Color.Orange: Color.Red;
            lblSabotValue.Text = Math.Round(sabotValue, 3).ToString();
        }

        public void setBank(HandData hand)
        {
            plBanUC.setHand(hand);
        }

        public void removePlayerPro()
        {
            if (playerPro != null)
            {
                playerPro = null;
                gbxPlayerPro.Controls.Clear();
            }
        }

        public void setNbCard(int nbCard)
        {
            lblNbCardValue.Text = nbCard.ToString();
        }
    }
}
