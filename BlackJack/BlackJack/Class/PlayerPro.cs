using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    class PlayerPro : Player
    {
        private const int SABOT_TO_PLAY = 2;
        private const int MAX_BET = 2000;
        public bool isPlaying = true;

        public PlayerPro(Game g,PlayerBank b,int cash) : base(g,b,cash)
        {
        }

        public override void play()
        {
            if (isPlaying)
            {
                for (int i = 0; i < lstHand.Count; i++)
                {
                    testEnoughCardInHand(i);
                    int handValue = lstHand[i].Value;
                    if (handValue == 16 || handValue == 18)
                    {
                        testSplit(i);
                        handValue = lstHand[i].Value;
                    }
                    if (g.realSabotValue >= SABOT_TO_PLAY && handValue <= 11 && handValue >= 7)
                    {
                        doubleBet(i);
                        return;
                    }
                    while (handValue <= 11)
                    {
                        addCard(i);
                        handValue = lstHand[i].Value;
                    }
                }
            }
        }

        public override void bet()
        {
            if (g.realSabotValue >= SABOT_TO_PLAY)
            {
                isPlaying = true;
                lstBetValue.Add(MAX_BET);
                cash -= MAX_BET;
            }
            else
            {
                isPlaying = false;
            }
        }

        private void testAddCard(int sabotMax, int id)
        {
            if (g.realSabotValue < sabotMax) { addCard(id); }
        }
    }
}
