using BlackJack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class TableData
    {
        public HandData HandBank { get; set; }
        public List<PlayerData> LstPlayer { get; set; } = new List<PlayerData>();
        public PlayerData PlayerPro { get; set; }
        public double SabotValue { get; set; }
        public int NbCard { get; set; }

        public TableData(Table table)
        {
            HandBank = new HandData(table.getBankHand());
            SabotValue = table.RealSabotValue;
            NbCard = table.getNbCardInDeck();
            PlayerPro = null;
            addPlayers(table.LstPlayer);
        }

        private void addPlayers(List<PlayerLambda> lstPlayer)
        {
            foreach (PlayerLambda p in lstPlayer)
            {
                LstPlayer.Add(new PlayerData(p));
            }
        }

        public void setPlayerPro(PlayerPro playerPro)
        {
            PlayerPro = new PlayerData(playerPro);
        }
    }
}
