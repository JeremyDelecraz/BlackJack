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

        public void setPlayers(List<List<int>> lstValue, List<List<int>> lstNbCard, List<int> cash)
        {
            int id = 0;
            String name = "";
            foreach (PlayerUC playerUC in gbxPlayer.Controls)
            {
                name = "Player " + id;
                ((PlayerUC)playerUC).setPlayer(lstValue[id], lstNbCard[id], cash[id],1,name);
                id++;
            }
            Point p = new Point(5, 12); // Bank
        }

        public void setPlayerPro(List<int> lstValue,List<int> lstNbCard, int cash)
        {
            if (playerPro == null)
            {
                playerPro = new PlayerUC();
                playerPro.Location = new Point(5, 12);
                gbxPlayerPro.Controls.Add(playerPro);
            }
            playerPro.setPlayer(lstValue, lstNbCard,cash, 0,"Player Pro");
        }

        public void setSabotValue(double sabotValue)
        {
            lblSabotValue.BackColor = (sabotValue > PlayerPro.SABOT_TO_PLAY) ? Color.Green : (sabotValue > PlayerPro.SABOT_TO_STAY) ? Color.Orange: Color.Red;
            lblSabotValue.Text = Math.Round(sabotValue, 3).ToString();
        }
        public void setBank(int value,int nbCard)
        {
            plBanUC.setHand(value, nbCard);
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
