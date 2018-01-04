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
    public partial class TableUC : UserControl
    {
        public TableUC()
        {
            InitializeComponent();
        }

        public void initTable(int nbPlayer, int tableNumber)
        {
            int x = 5;
            int y = 12;
            int distX = 392;
            int distY = 70;
            lblNbTableValue.Text = tableNumber.ToString();
            for (int i = 0; i < nbPlayer; i++)
            {
                playerUC playerUC = new playerUC();
                playerUC.Location = new Point(((i%2 != 0) ? (x + distX) : x), y);
                if (i % 2 != 0) {y += distY;}
                gbxPlayer.Controls.Add(playerUC);
            }
        }

        public void setPlayers(List<List<List<int>>> lstHandIndexImage, List<List<int>> lstValue, List<int> cash)
        {
            int id = 0;
            String name = "";
            foreach (playerUC playerUC in gbxPlayer.Controls)
            {
                name = "Player " + id;
                ((playerUC)playerUC).setPlayer(lstHandIndexImage[id], lstValue[id],cash[id],1,name);
                id++;
            }
            Point p = new Point(5, 12); // Bank
        }

        public void setPlayerPro(List<List<int>> lstHandIndexImage, List<int> lstValue, int cash)
        {
            playerUC playerUC = new playerUC();
            playerUC.Location = new Point(5, 12);
            playerUC.setPlayer(lstHandIndexImage,lstValue,cash,0,"Player Pro");
            gbxPlayerPro.Controls.Add(playerUC);
        }

        public void setBank(List<int> lstIndexImage, int value)
        {
            plBanUC.setHand(lstIndexImage, value);
        }

        public void removePlayerPro()
        {
            gbxPlayerPro.Controls.Clear();
        }
    }
}
