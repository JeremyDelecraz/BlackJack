using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class Player
    {
        private const int BLACKJACK = 21;
        private int nbWin = 0;
        private int nbLose = 0;
        private int nbEqual = 0;
        protected int cash = 50000;
        protected List<int> lstBetValue = new List<int>();
        protected List<Hand> lstHand = new List<Hand>();
        protected Game g;
        protected PlayerBank b;

        public Player(Game g,PlayerBank b,int cash) {
            this.g = g;
            this.b = b;
            this.cash = cash;
        }

        public Player(Game g)
        {
            this.g = g;
        }

        public virtual void play()
        {
        }

        public virtual void bet()
        {
        }
        
        public void testSplit(int id)
        {
            if (lstHand[id].isSameCard())
            {
                split(id);
            }
        }

        public void split(int id)
        {
            Hand h = new Hand(lstHand[id].removeLastCard());
            lstHand.Add(h);
            lstHand[id].Value /= 2;
            lstHand[id].addCard(g.requestCard());
            lstBetValue.Add(lstBetValue[id]);
            testSplit(id);
        }

        public void addCard(int id)
        {
            if (!lstHand.Any()) {
                lstHand.Add(new Hand());
            }
            lstHand[id].addCard(g.requestCard());
        }
        
        public void verifWinLose(int bankValue,int bankCard)
        {
            for (int i = 0; i < lstHand.Count; i++)
            {
                int handValue = lstHand[i].Value;
                if (handValue > BLACKJACK) { loseCash(i); return; }
                if (handValue == BLACKJACK && lstHand[i].getNbCard() == 2 && lstHand.Count == 1) { winBlackJack(i); return; }
                if (bankValue > BLACKJACK && handValue <= BLACKJACK) { winCash(i); return; }
                if (bankValue == BLACKJACK && bankCard == 2) { loseCash(i); return; }
                if (bankValue == handValue) { equalCash(i); return; }
                if (bankValue <= BLACKJACK && handValue > bankValue) { winCash(i); return; }
                if (handValue < bankValue) { loseCash(i); return; }
            }
        }

        public void winBlackJack(int id)
        {
            int cashWin = lstBetValue[id] / 2;
            this.cash += cashWin;
            b.cash -= cashWin;
            winCash(id);
        }

        public void winCash(int id)
        {
            this.cash += lstBetValue[id] * 2;
            b.cash -= lstBetValue[id];
            nbWin++;
        }

        public void equalCash(int id)
        {
            this.cash += lstBetValue[id];
            nbEqual++;
        }

        public void loseCash(int id)
        {
            nbLose++;
            b.cash += lstBetValue[id];
        }

        public void resetHand()
        {
            lstHand.Clear();
            lstBetValue.Clear();
        }

        public void doubleBet(int id)
        {
            cash -= lstBetValue[id];
            lstBetValue[id] *= 2;
            addCard(id);
        }

        public void testEnoughCardInHand(int id)
        {
            if (lstHand[id].getNbCard() < 2)
            {
                lstHand[id].addCard(g.requestCard());
            }
        }

        public int getHandValue(int id)
        {
            return lstHand[id].Value;
        }

        public int getNbCard(int id)
        {
            return lstHand[id].getNbCard();
        }

        public int getNbWin()
        {
            return this.nbWin;
        }

        public int getNbEqual()
        {
            return this.nbEqual;
        }

        public int getNbLose()
        {
            return this.nbLose;
        }

        public int getCash()
        {
            return this.cash;
        }
    }
}
