using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class PlayerLambda : Player
    {
        private const int BET = 50;

        public PlayerLambda(Game g, PlayerBank b, int cash) : base(g,b,cash)
        {
        }

        public override void play()
        {
            for (int i = 0; i < lstHand.Count; i++)
            {
                testEnoughCardInHand(i);
                int handValue = lstHand[i].Value;
                if (handValue >= 20)
                {
                    testSplit(i);
                    handValue = lstHand[i].Value;
                }
                int firstCardBank = b.getFirstCard();
                if (handValue <= 11 && handValue >= 9)
                {
                    doubleBet(i);
                    return;
                }
                while (handValue <= 11)
                {
                    addCard(i);
                    handValue = lstHand[i].Value;
                }
                if (firstCardBank >= 8 && handValue <= 13) { addCard(i); }
            }
        }

        public override void bet()
        {
            lstBetValue.Add(BET);
            cash -= BET;
        }
    }
}
