using BlackJack.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    public class PlayerData
    {
        public List<HandData> LstHand { get; set; } = new List<HandData>();
        public int Cash { get; set; }
        public int NbWin { get; set; }
        public int NbEqual { get; set; }
        public int NbLose { get; set; }

        public PlayerData(Player p)
        {
            Cash = p.Cash;
            NbWin = p.NbWin;
            NbEqual = p.NbEqual;
            NbLose = p.NbLose;
            addLstHand(p.LstHand);
        }

        public void addLstHand(List<Hand> lstHand)
        {
            foreach (Hand h in lstHand)
            {
                LstHand.Add(new HandData(h));
            }
        }
    }
}
