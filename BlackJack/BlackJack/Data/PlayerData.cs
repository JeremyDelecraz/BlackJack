using BlackJack.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Data
{
    class PlayerData
    {
        public List<HandData> LstHand { get; set; } = new List<HandData>();
        public int Cash { get; set; }

        public int NbWin { get; set; }
        public int NbEqual { get; set; }
        public int NbLose { get; set; }

        public PlayerData(int cash,int nbWin,int nbEqual,int nbLose,List<Hand> lstHand)
        {
            Cash = cash;
            NbWin = nbWin;
            NbEqual = nbEqual;
            NbLose = nbLose;
            addLstHand(lstHand);
        }

        public void addLstHand(List<Hand> lstHand)
        {
            foreach (Hand h in lstHand)
            {
                LstHand.Add(new HandData(h.Value, h.getNbCard()));
            }
        }
    }
}
