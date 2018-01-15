using BlackJack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class TableData
    {
        public Hand HandBank { get; set; }
        public List<PlayerData> LstPlayer { get; set; } = new List<PlayerData>();
        public PlayerData PlayerPro { get; set; }
        public double SabotValue { get; set; }
        public int NbCard { get; set; }

        public TableData(Hand handBank, double sabotValue,int nbCard, List<PlayerLambda> lstPlayer, PlayerPro playerPro)
        {
            HandBank = handBank;
            SabotValue = sabotValue;
            NbCard = nbCard;
            PlayerPro = new PlayerData(playerPro.Cash, playerPro.NbWin, playerPro.NbEqual,playerPro.NbLose,playerPro.LstHand);
            addPlayers(lstPlayer);
        }

        public TableData(Hand handBank, double sabotValue, int nbCard, List<PlayerLambda> lstPlayer)
        {
            HandBank = handBank;
            SabotValue = sabotValue;
            NbCard = nbCard;
            PlayerPro = null;
            addPlayers(lstPlayer);
        }

        private void addPlayers(List<PlayerLambda> lstPlayer)
        {
            foreach (PlayerLambda p in lstPlayer)
            {
                LstPlayer.Add(new PlayerData(p.Cash, p.NbWin, p.NbEqual, p.NbLose, p.LstHand));
            }
        }
    }
}
